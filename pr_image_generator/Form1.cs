using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace pr_image_generator
{
    public partial class mainWindow : Form
    {
        /// <summary>
        /// Stores information about the image as configurations are made
        /// </summary>
        private PRImage pr;

        /// <summary>
        /// Stores the image previews for each tab
        /// </summary>
        private PictureBox[] tabPictureBoxes;


        #region INITIALIZATION
        /**************************************************************************** 
         ***************************** INITIALIZATION *******************************
         *
         * -Methods associated with initialization of the program
         *
         ****************************************************************************/



        /// <summary>
        /// Initializes a new instance of the <see cref="mainWindow"/> class.
        /// </summary>
        public mainWindow()
        {
            InitializeComponent();
            pr = new PRImage();
            pictureBoxHeaderImage.Image = (Image)new Bitmap(Image.FromFile(textBoxHeaderImage.Text), new Size(267, 53));
            
            //fill in tabPictureBoxes; if more tabs are added to the program later, the preview pictureBox will have to be added here
            tabPictureBoxes = new PictureBox[4];
            tabPictureBoxes[0] = pictureBoxHeaderTab;
            tabPictureBoxes[1] = pictureBoxDataTab;
            tabPictureBoxes[2] = pictureBoxDivisionsTab;
            tabPictureBoxes[3] = pictureBoxColoursTab;
    
        }

        #endregion






        #region HEADER
        /**************************************************************************** 
         ***************************** HEADER METHODS *******************************
         *
         * -Methods associated with controls in the Header tab
         * 
         ****************************************************************************/

        
        /// <summary>
        /// Called when the Game TextBox is updated, load divisions and colours for the game if present  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textGame_Leave(object sender, EventArgs e)
        {
            string convertedGameName = textGame.Text.ToLower().Replace(" ", string.Empty);
            //get default header image, if present
            string potentialDefaultImage = "images/header_" + convertedGameName + ".png";
            if (File.Exists(potentialDefaultImage))
            {
                textBoxHeaderImage.Text = potentialDefaultImage;
                try
                {
                    pictureBoxHeaderImage.Image = (Image)new Bitmap(Image.FromFile(potentialDefaultImage), new Size(267, 53));
                }
                catch
                {
                    MessageBox.Show(String.Format("Error opening image {0}", potentialDefaultImage));
                }
            }

            //load game default divisions, if available
            labelCurrentDivisionsSet.Text = "Currently using [" + convertedGameName + "] divisions";

            try
            {
                XmlDocument config = new XmlDocument();
                config.Load("config.xml");

                try
                {
                    string xpath = "/config/divisions[@game='" + convertedGameName + "']";
                    XmlNode divisions = config.DocumentElement.SelectSingleNode(xpath);

                    // divisions preconfiguration was found, so delete current divisions and load
                    int divisionsCount = listViewDivisions.Items.Count;
                    for (int i = 0; i < divisionsCount; i = i + 1)
                    {
                        listViewDivisions.Items.Remove(listViewDivisions.Items[0]);
                        pr.removeDivision(0);
                    }


                    XmlNode divisionNode = divisions.FirstChild;
                    string[] fields = new string[4];
                    XmlNode divisionField;
                    int index = 0;

                    //parse divisions and populate fields
                    while (divisionNode != null)
                    {
                        divisionField = divisionNode.FirstChild;
                        while (divisionField != null)
                        {
                            fields[index] = divisionField.InnerText;
                            index = index + 1;
                            divisionField = divisionField.NextSibling;
                        }

                        pr.addDivision(fields);
                        listViewDivisions.Items.Add(new ListViewItem(fields));
                        listViewDivisions.ListViewItemSorter = new DivisionsELOComparer(3);  //setting Sorter will automatically sort the ListView; 3 denotes column index representing ELO

                        index = 0;
                        divisionNode = divisionNode.NextSibling;
                    }

                }
                catch
                {
                    //game does not have preconfigured divisions, so do nothing
                }

                //load game default colours, if available
                labelCurrentColourSet.Text = "Currently using [" + convertedGameName + "] colours";

                try
                {
                    string xpath = "/config/colors[@game='" + convertedGameName + "']";
                    XmlNode colors = config.DocumentElement.SelectSingleNode(xpath);

                    //parse colors and populate fields
                    XmlNode colorField = colors.FirstChild;

                    setTextBoxColourFromLine(textBoxMainTextColour, colorField.InnerText); // first field is MainTextColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxHeaderTextColour, colorField.InnerText); // second field is HeaderText Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxRegionTextColour, colorField.InnerText); // third field is RegionNameColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxGameNameColour, colorField.InnerText); // fourth field is GameNameColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxLine1Colour, colorField.InnerText); // fifth field is Line1Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxLine2Colour, colorField.InnerText); // sixth field is Line2Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxPlusColour, colorField.InnerText); // seventh field is plusColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxMinusColour, colorField.InnerText); // eighth field is minusColour                

                }
                catch
                {
                    //game does not have preconfigured colours, so do nothing
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("config.xml file not found in current directory.  Please obtain config.xml from program .zip");
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);

        }

 
        /// <summary>
        /// Occurs when the Header Image TextBox is updated, update the header image preview 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxHeaderImage_Leave(object sender, EventArgs e)
        {
            if (!File.Exists(textBoxHeaderImage.Text))
            {
                MessageBox.Show("Warning: Image not found");
                return;
            }

            try
            {
                pictureBoxHeaderImage.Image = (Image)new Bitmap(Image.FromFile(textBoxHeaderImage.Text), new Size(267, 53));
            }
            catch
            {
                MessageBox.Show(String.Format("Error opening image {0}", textBoxHeaderImage.Text));
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);

        }


             
        /// <summary>
        /// Opens file dialog so that user can select a header image  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowseHeaderImage_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialogCsv.FileName;
                textBoxHeaderImage.Text = file;
                try
                {
                    pictureBoxHeaderImage.Image = (Image)new Bitmap(Image.FromFile(file), new Size(267, 53));
                    updatePRImage();
                    pr.updatePreview(tabPictureBoxes);
                }
                catch
                {
                    MessageBox.Show(String.Format("Error opening image {0}", file));
                }
            }
        }

        #endregion






        #region DATA
        /**************************************************************************** 
         ****************************** DATA METHODS ********************************
         *
         * -Methods associated with controls in the Data tab
         * 
         ****************************************************************************/



        
        /// <summary>
        /// Opens file dialog so that user can select an input CSV file  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowseCsv_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialogCsv.FileName;

                int length = file.Length;
                if (file.Substring(length - 4) != ".csv")
                {
                    MessageBox.Show("WARNING:\n Please ensure the import file is in CSV format. PR Image Generator will attempt to run anyways, but will fail if chosen file is not properly formatted.");
                }
                textCsv.Text = file;

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);

            }
        }


        /// <summary>
        /// Opens file dialog so that user can select an input previous CSV file  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowsePrevCsv_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {   
                string file = openFileDialogCsv.FileName;

                int length = file.Length;
                if (file.Substring(length - 4) != ".csv")
                {
                    MessageBox.Show("WARNING:\n Please ensure the import file is in CSV format. PR Image Generator will attempt to run anyways, but will fail if chosen file is not properly formatted.");
                }
                textPrevCsv.Text = file;
                updatePRImage();
                pr.updatePreview(tabPictureBoxes);

            }
        }


        /// <summary>
        /// Opens file dialog so that user can select an input exclusion list file 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowseExclusionList_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialogCsv.FileName;

                int length = file.Length;
                if (file.Substring(length - 4) != ".csv")
                {
                    MessageBox.Show("WARNING:\n Please ensure the import file is in CSV format. PR Image Generator will attempt to run anyways, but will fail if chosen file is not properly formatted.");
                }

                textExclusionList.Text = file;
                updatePRImage();
                pr.updatePreview(tabPictureBoxes);

            }
        }


        /// <summary>
        /// Opens file dialog so that user can select an input character map file 
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowseCharMap_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogCsv.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialogCsv.FileName;

                int length = file.Length;
                if (file.Substring(length - 4) != ".csv")
                {
                    MessageBox.Show("WARNING:\n Please ensure the import file is in CSV format. PR Image Generator will attempt to run anyways, but will fail if chosen file is not properly formatted.");
                }
                textCharMap.Text = file;
                updatePRImage();
                pr.updatePreview(tabPictureBoxes);

            }
        }



        #endregion





        #region DIVISIONS
        /**************************************************************************** 
         *************************** DIVISIONS METHODS ******************************
         *
         * -Methods associated with controls in the Divisions tab
         * 
         ****************************************************************************/


        
        /// <summary>
        /// Saves the current divisions in config.xml under the specified game  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSaveDivisions_Click(object sender, EventArgs e)
        {
            if (textGame.Text == string.Empty)
            {
                MessageBox.Show("Please specify a game name before attempting to save divisions");
                return;
            }
            try
            {
                XmlDocument config = new XmlDocument();
                config.Load("config.xml");
                try
                {
                    string xpath = "/config/divisions[@game='" + textGame.Text.ToLower().Replace(" ", string.Empty) + "']";
                    XmlNode divisions = config.DocumentElement.SelectSingleNode(xpath);

                    //delete all child nodes
                    divisions.RemoveAll();
                    XmlAttribute gameAttribute = config.CreateAttribute("game");
                    gameAttribute.Value = textGame.Text.ToLower().Replace(" ", string.Empty);
                    divisions.Attributes.Append(gameAttribute);

                    //get all divisions from the control
                    foreach (ListViewItem item in listViewDivisions.Items)
                    {
                        //create new division
                        XmlNode newDivision = config.CreateElement("division");

                        //populate new division with children
                        XmlNode newDivisionName = config.CreateElement("Name");
                        newDivisionName.InnerText = item.SubItems[0].Text;
                        XmlNode newDivisionTextColour = config.CreateElement("TextColour");
                        newDivisionTextColour.InnerText = item.SubItems[1].Text;
                        XmlNode newDivisionBGColour = config.CreateElement("BGColour");
                        newDivisionBGColour.InnerText = item.SubItems[2].Text;
                        XmlNode newDivisionCutoff = config.CreateElement("Cutoff");
                        newDivisionCutoff.InnerText = item.SubItems[3].Text;

                        newDivision.AppendChild(newDivisionName);
                        newDivision.AppendChild(newDivisionTextColour);
                        newDivision.AppendChild(newDivisionBGColour);
                        newDivision.AppendChild(newDivisionCutoff);

                        //append division to parent node
                        divisions.AppendChild(newDivision);
                    }
                }
                catch
                {
                    //game does not have preconfigured colours, so add the configuration
                    XmlElement newDivisionsNode = config.CreateElement("divisions");
                    newDivisionsNode.SetAttribute("game", textGame.Text.ToLower().Replace(" ", string.Empty));

                    //create XmlElements for all divisions and division fields
                    foreach (ListViewItem item in listViewDivisions.Items)
                    {
                        //create new division
                        XmlNode newDivision = config.CreateElement("division");

                        //populate new division with children
                        XmlNode newDivisionName = config.CreateElement("Name");
                        newDivisionName.InnerText = item.SubItems[0].Text;
                        XmlNode newDivisionTextColour = config.CreateElement("TextColour");
                        newDivisionTextColour.InnerText = item.SubItems[1].Text;
                        XmlNode newDivisionBGColour = config.CreateElement("BGColour");
                        newDivisionBGColour.InnerText = item.SubItems[2].Text;
                        XmlNode newDivisionCutoff = config.CreateElement("Cutoff");
                        newDivisionCutoff.InnerText = item.SubItems[3].Text;

                        newDivision.AppendChild(newDivisionName);
                        newDivision.AppendChild(newDivisionTextColour);
                        newDivision.AppendChild(newDivisionBGColour);
                        newDivision.AppendChild(newDivisionCutoff);

                        //append division to parent node
                        newDivisionsNode.AppendChild(newDivision);
                    }

                    XmlNode root = config.DocumentElement.SelectSingleNode("/config");
                    root.AppendChild(newDivisionsNode);
                }
                config.Save("config.xml");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("config.xml file not found in current directory.  Please obtain config.xml from program .zip");
            }

            MessageBox.Show("Divisions saved for " + textGame.Text.ToLower().Replace(" ", string.Empty) + " to config.xml");
        }



        /// <summary>
        /// Loads the current divisions from config.xml for the specified game  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonLoadDivisions_Click(object sender, EventArgs e)
        {
            XmlDocument config = new XmlDocument();
            config.Load("config.xml");

            try
            {
                string xpath = "/config/divisions[@game='" + textGame.Text.ToLower().Replace(" ", string.Empty) + "']";
                XmlNode divisions = config.DocumentElement.SelectSingleNode(xpath);

                // divisions preconfiguration was found, so delete current divisions and load
                int divisionsCount = listViewDivisions.Items.Count;
                for (int i = 0; i < divisionsCount; i = i + 1)
                {
                    listViewDivisions.Items.Remove(listViewDivisions.Items[0]);
                    pr.removeDivision(0);
                }


                XmlNode divisionNode = divisions.FirstChild;
                string[] fields = new string[4];
                XmlNode divisionField;
                int index = 0;

                //parse divisions and populate fields, adding to appropriate places when complete
                while (divisionNode != null)
                {
                    divisionField = divisionNode.FirstChild;
                    while (divisionField != null)
                    {
                        fields[index] = divisionField.InnerText;
                        index = index + 1;
                        divisionField = divisionField.NextSibling;
                    }

                    pr.addDivision(fields);
                    listViewDivisions.Items.Add(new ListViewItem(fields));
                    listViewDivisions.ListViewItemSorter = new DivisionsELOComparer(3);  //setting Sorter will automatically sort the ListView; 3 denotes column index representing ELO

                    index = 0;
                    divisionNode = divisionNode.NextSibling;
                }

                pr.updatePreview(tabPictureBoxes);
            }
            catch
            {
                //game does not have preconfigured divisions
                MessageBox.Show("No preconfigured divisions found for game " + textGame.Text);
            }
        }


    
        /// <summary>
        /// Updates the background colour of the Division Text textbox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxAddDivisionTextColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxAddDivisionTextColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxAddDivisionTextColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxAddDivisionTextColour.Text.Substring(4, 2), 16);

                textBoxAddDivisionTextColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxAddDivisionTextColour.BackColor = Color.White;
                textBoxAddDivisionTextColour.Text = "#INVALID";
            }

        }


        /// <summary>
        /// Updates the background colour of the Division Background Textbox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxAddDivisionBGColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxAddDivisionBGColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxAddDivisionBGColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxAddDivisionBGColour.Text.Substring(4, 2), 16);

                textBoxAddDivisionBGColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxAddDivisionBGColour.BackColor = Color.White;
                textBoxAddDivisionBGColour.Text = "#INVALID";
            }
        }


        
        /// <summary>
        /// Opens colour dialog so that user can select a colour   
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonDivisionsTextColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAddDivisionTextColour.BackColor = colorDialog1.Color;
                textBoxAddDivisionTextColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

            }
        }


        /// <summary>
        /// Opens colour dialog so that user can select a colour   
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonDivionsBGColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxAddDivisionBGColour.BackColor = colorDialog1.Color;
                textBoxAddDivisionBGColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

            }
        }


       
        /// <summary>
        /// Takes the data from the four TextBoxes in this tab and adds to the division list
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <remarks>Note that this method also updates the divisions in the PRImage class.</remarks>
        private void buttonAddDivision_Click(object sender, EventArgs e)
        {
            string[] fields = new string[4];

            // get name field
            fields[0] = textBoxAddDivisionName.Text;

            // get text colour and check for invalid
            if (textBoxAddDivisionTextColour.Text.Equals("#INVALID"))
            {
                MessageBox.Show("Please specify a valid hex code for Text Colour.");
                return;
            }
            else
            {
                fields[1] = textBoxAddDivisionTextColour.Text;
            }

            // get BG colour and check for invalid
            if (textBoxAddDivisionBGColour.Text.Equals("#INVALID"))
            {
                MessageBox.Show("Please specify a valid hex code for BG Colour.");
                return;
            }
            else
            {
                fields[2] = textBoxAddDivisionBGColour.Text;
            }

            // get cutoff and check that it is an integer value
            try
            {
                int.Parse(textBoxAddDivisionCutoff.Text);
            }
            catch
            {
                MessageBox.Show("Please specify a valid number for ELO cutoff.");
                return;
            }

            // check to ensure that ELO value given is distinct
            foreach (ListViewItem item in listViewDivisions.Items)
            {
                if (string.Compare(textBoxAddDivisionCutoff.Text, item.SubItems[3].Text) == 0)
                {
                    MessageBox.Show("ELO Value already in list.");
                    return;
                }
            }

            fields[3] = textBoxAddDivisionCutoff.Text;

            pr.addDivision(fields);
                                    
            listViewDivisions.Items.Add(new ListViewItem(fields));
            listViewDivisions.ListViewItemSorter = new DivisionsELOComparer(3);  //setting Sorter will automatically sort the ListView; 3 denotes column index representing ELO

            //no need to update the PR object in this case since the divisions are manually updated as they are added or removed
            pr.updatePreview(tabPictureBoxes);
            
        }


      
        /// <summary>
        /// Removes the selected divisions from the list
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <remarks>Note that this method also updates the divisions in the PRImage class.</remarks>
        private void buttonRemoveDivision_Click(object sender, EventArgs e)
        {
            int offset = 0;
            foreach (int index in listViewDivisions.SelectedIndices)
            {
                listViewDivisions.Items.Remove(listViewDivisions.Items[index - offset]);
                pr.removeDivision(index);
                offset = offset + 1;
            }

            //no need to update the PR object in this case since the divisions are manually updated as they are added or removed
            pr.updatePreview(tabPictureBoxes);
        }


      
        /// <summary>
        /// Auxiliary class used to enable sorting of divisions by ELO
        /// </summary>
        /// <seealso cref="System.Collections.IComparer" />
        class DivisionsELOComparer : IComparer
        {
            private int sortColumn;
            public DivisionsELOComparer()
            {
                sortColumn = 0;
            }
            public DivisionsELOComparer(int column)
            {
                sortColumn = column;
            }
            public int Compare(object x, object y)
            {
                if (Int32.Parse(((ListViewItem)x).SubItems[sortColumn].Text) > Int32.Parse(((ListViewItem)y).SubItems[sortColumn].Text))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        #endregion





        #region COLOURS
        /**************************************************************************** 
         **************************** COLOURS METHODS *******************************
         *
         * -Methods associated with controls in the Colours tab
         * 
         ****************************************************************************/


         
        /// <summary>
        /// Saves current colours for the current game in config.xml  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonSaveColours_Click(object sender, EventArgs e)
        {
            if (textGame.Text == string.Empty)
            {
                MessageBox.Show("Please specify a game name before attempting to save colours");
                return;
            }
            try
            {
                
                XmlDocument config = new XmlDocument();
                config.Load("config.xml");
                try
                {
                    string xpath = "/config/colors[@game='" + textGame.Text.ToLower().Replace(" ", string.Empty) + "']";
                    XmlNode colors = config.DocumentElement.SelectSingleNode(xpath);

                    //parse colors and populate fields
                    XmlNode colorField = colors.FirstChild;

                    colorField.InnerText = textBoxMainTextColour.Text; // first field is MainTextColour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxHeaderTextColour.Text; // second field is HeaderText Colour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxRegionTextColour.Text; // third field is RegionNameColour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxGameNameColour.Text; // fourth field is GameNameColour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxLine1Colour.Text; // fifth field is Line1Colour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxLine2Colour.Text; // sixth field is Line2Colour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxPlusColour.Text; // seventh field is plusColour
                    colorField = colorField.NextSibling;
                    colorField.InnerText = textBoxMinusColour.Text; // eighth field is minusColour
                }
                catch
                {
                    //game does not have preconfigured colours, so add the configuration
                    XmlElement newColorsNode = config.CreateElement("colors");
                    newColorsNode.SetAttribute("game", textGame.Text.ToLower().Replace(" ", string.Empty));

                    //create XmlElements for all eight colours
                    XmlElement mainTextColourNode = config.CreateElement("MainTextColour");
                    XmlElement headerTextColourNode = config.CreateElement("HeaderTextColour");
                    XmlElement regionNameColourNode = config.CreateElement("RegionNameColour");
                    XmlElement gameNameColourNode = config.CreateElement("GameNameColour");
                    XmlElement line1ColourNode = config.CreateElement("Line1Colour");
                    XmlElement line2ColourNode = config.CreateElement("Line2Colour");
                    XmlElement plusColourNode = config.CreateElement("plusColour");
                    XmlElement minusColourNode = config.CreateElement("minusColour");

                    //set values for the nodes
                    mainTextColourNode.InnerText = textBoxMainTextColour.Text;
                    headerTextColourNode.InnerText = textBoxHeaderTextColour.Text;
                    regionNameColourNode.InnerText = textBoxRegionTextColour.Text;
                    gameNameColourNode.InnerText = textBoxGameNameColour.Text;
                    line1ColourNode.InnerText = textBoxLine1Colour.Text;
                    line2ColourNode.InnerText = textBoxLine2Colour.Text;
                    plusColourNode.InnerText = textBoxPlusColour.Text;
                    minusColourNode.InnerText = textBoxMinusColour.Text;

                    //construct XML tree
                    newColorsNode.AppendChild(mainTextColourNode);
                    newColorsNode.AppendChild(headerTextColourNode);
                    newColorsNode.AppendChild(regionNameColourNode);
                    newColorsNode.AppendChild(gameNameColourNode);
                    newColorsNode.AppendChild(line1ColourNode);
                    newColorsNode.AppendChild(line2ColourNode);
                    newColorsNode.AppendChild(plusColourNode);
                    newColorsNode.AppendChild(minusColourNode);

                    XmlNode root = config.DocumentElement.SelectSingleNode("/config");
                    root.AppendChild(newColorsNode);
                }
                config.Save("config.xml");
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("config.xml file not found in current directory.  Please obtain config.xml from program .zip");
            }

            MessageBox.Show("Colours saved for " + textGame.Text.ToLower().Replace(" ", string.Empty) + " to config.xml");
        }


        
        /// <summary>
        /// Loads current colours for the current game from config.xml  
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonLoadColours_Click(object sender, EventArgs e)
        {
            try
            {
                XmlDocument config = new XmlDocument();
                config.Load("config.xml");
                try
                {
                    string xpath = "/config/colors[@game='" + textGame.Text.ToLower().Replace(" ", string.Empty) + "']";
                    XmlNode colors = config.DocumentElement.SelectSingleNode(xpath);

                    //parse colors and populate fields
                    XmlNode colorField = colors.FirstChild;

                    setTextBoxColourFromLine(textBoxMainTextColour, colorField.InnerText); // first field is MainTextColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxHeaderTextColour, colorField.InnerText); // second field is HeaderText Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxRegionTextColour, colorField.InnerText); // third field is RegionNameColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxGameNameColour, colorField.InnerText); // fourth field is GameNameColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxLine1Colour, colorField.InnerText); // fifth field is Line1Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxLine2Colour, colorField.InnerText); // sixth field is Line2Colour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxPlusColour, colorField.InnerText); // seventh field is plusColour
                    colorField = colorField.NextSibling;
                    setTextBoxColourFromLine(textBoxMinusColour, colorField.InnerText); // eighth field is minusColour
                }
                catch
                {
                    //game does not have preconfigured colours
                    MessageBox.Show("No preconfigured colours found for game " + textGame.Text);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("config.xml file not found in current directory.  Please obtain config.xml from program .zip");
            }
        }



        
        /// <summary>
        /// Opens colour dialog so user can select a colour for Main Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonMainTextColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxMainTextColour.BackColor = colorDialog1.Color;
                textBoxMainTextColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);
                
                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }

        }
        

        /// <summary>
        /// Updates background colour of the Main Text TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxMainTextColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxMainTextColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxMainTextColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxMainTextColour.Text.Substring(4, 2), 16);

                textBoxMainTextColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxMainTextColour.BackColor = Color.White;
                textBoxMainTextColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        
        /// <summary>
        /// Opens colour dialog so user can select a colour for Header Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonHeaderTextColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxHeaderTextColour.BackColor = colorDialog1.Color;
                textBoxHeaderTextColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }

        }


        /// <summary>
        /// Updates background colour of the Header Text TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxHeaderTextColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxHeaderTextColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxHeaderTextColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxHeaderTextColour.Text.Substring(4, 2), 16);

                textBoxHeaderTextColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxHeaderTextColour.BackColor = Color.White;
                textBoxHeaderTextColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }

        

        /// <summary>
        /// Updates background colour of the Region Text TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxRegionTextColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxRegionTextColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxRegionTextColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxRegionTextColour.Text.Substring(4, 2), 16);

                textBoxRegionTextColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxRegionTextColour.BackColor = Color.White;
                textBoxRegionTextColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Region Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>        
        private void buttonRegionTextColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxRegionTextColour.BackColor = colorDialog1.Color;
                textBoxRegionTextColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }


        
        /// <summary>
        /// Updates background colour of the Game TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxGameNameColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxGameNameColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxGameNameColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxGameNameColour.Text.Substring(4, 2), 16);

                textBoxGameNameColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxGameNameColour.BackColor = Color.White;
                textBoxGameNameColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Game Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonGameNameColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxGameNameColour.BackColor = colorDialog1.Color;
                textBoxGameNameColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }

        

        /// <summary>
        /// Updates background colour of the Line1 TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxLine1Colour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxLine1Colour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxLine1Colour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxLine1Colour.Text.Substring(4, 2), 16);

                textBoxLine1Colour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxLine1Colour.BackColor = Color.White;
                textBoxLine1Colour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Line1 Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonLine1Colour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxLine1Colour.BackColor = colorDialog1.Color;
                textBoxLine1Colour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }
        

        /// <summary>
        /// Updates background colour of the Line2 Text TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxLine2Colour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxLine2Colour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxLine2Colour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxLine2Colour.Text.Substring(4, 2), 16);

                textBoxLine2Colour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxLine2Colour.BackColor = Color.White;
                textBoxLine2Colour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Line2 Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonLine2Colour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxLine2Colour.BackColor = colorDialog1.Color;
                textBoxLine2Colour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }

        
        /// <summary>
        /// Updates background colour of the Plus Text TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxPlusColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxPlusColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxPlusColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxPlusColour.Text.Substring(4, 2), 16);

                textBoxPlusColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxPlusColour.BackColor = Color.White;
                textBoxPlusColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Plus Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonPlusColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxPlusColour.BackColor = colorDialog1.Color;
                textBoxPlusColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }

        

        /// <summary>
        /// Updates background colour of the Minus TextBox when a new value is entered
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void textBoxMinusColour_Leave(object sender, EventArgs e)
        {
            try
            {
                int red = Convert.ToInt32(textBoxMinusColour.Text.Substring(0, 2), 16);
                int green = Convert.ToInt32(textBoxMinusColour.Text.Substring(2, 2), 16);
                int blue = Convert.ToInt32(textBoxMinusColour.Text.Substring(4, 2), 16);

                textBoxMinusColour.BackColor = Color.FromArgb(red, green, blue);
            }
            catch
            {
                textBoxMinusColour.BackColor = Color.White;
                textBoxMinusColour.Text = "#INVALID";
            }

            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


        /// <summary>
        /// Opens colour dialog so user can select a colour for Minus Text
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonMinusColour_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxMinusColour.BackColor = colorDialog1.Color;
                textBoxMinusColour.Text = colorDialog1.Color.ToArgb().ToString("X").Substring(2);

                updatePRImage();
                pr.updatePreview(tabPictureBoxes);
            }
        }


    
        /// <summary>
        /// Auxiliary method to help loading colours from config.xml.  Also sets background colour of a specified 
        /// TextBox once the hex string for the colour is known.
        /// </summary>
        /// <param name="t">The TextBox whose colour is to be set.</param>
        /// <param name="colour">The string representation of the colour to be parsed.</param>
        private void setTextBoxColourFromLine(TextBox t, string colour)
        {
            try
            {
                int red = Convert.ToInt32(colour.Substring(0, 2), 16);
                int green = Convert.ToInt32(colour.Substring(2, 2), 16);
                int blue = Convert.ToInt32(colour.Substring(4, 2), 16);

                t.BackColor = Color.FromArgb(red, green, blue);
                t.Text = colour;
            }
            catch
            {
                t.BackColor = Color.White;
                t.Text = "#INVALID";
            }
        }

        #endregion


        


        #region COMMON
        /**************************************************************************** 
         **************************** COMMON METHODS ********************************
         *
         * -Methods that are not associated with any given tab
         * 
         ****************************************************************************/



     
        /// <summary>
        /// Updates the PR image with newly specified information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <remarks>This method can be set as the callback for "generic" UI elements that simply need to update the 
        /// PRImage with new information, without affecting any other UI elements.</remarks>
        private void generic_Leave(object sender, EventArgs e)
        {
            updatePRImage();
            pr.updatePreview(tabPictureBoxes);
        }


       
        /// <summary>
        /// Opens Save File dialog to allow the user to specify a save location.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonBrowseSave_Click(object sender, EventArgs e)
        {
            DialogResult result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = saveFileDialog.FileName;
                textSaveHeaderTab.Text = file;
                textSaveDataTab.Text = file;
                textSaveDivisionsTab.Text = file;
                textSaveColoursTab.Text = file;
            }
        }

    
        /// <summary>
        /// Cues the PRImage to actually generate the image, and saves the result in the specified location.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            string save = textSaveHeaderTab.Text; // note: could use Save text in any of the tabs, since it should be mirrored

            if (save == string.Empty)
            {
                MessageBox.Show("Please specify a location to save the image.");
                return;
            }

            updatePRImage();
            Image result = pr.drawPR();

            result.Save(save, ImageFormat.Png);
            MessageBox.Show("Image saved to " + save);
            return;

        }


      
        /// <summary>
        /// Synchronizes the internal PRImage state with the information specified in the controls.
        /// </summary>
        /// <remarks>This can be called after anything changes in the UI, and should also be called 
        /// just before generating the actual image.</remarks>
        private void updatePRImage()
        {
            pr.setGame(textGame.Text);
            if (comboBoxIconSet.SelectedItem == null)
            {
                pr.setIconSet(string.Empty);
            }
            else
            {
                pr.setIconSet(comboBoxIconSet.SelectedItem.ToString());
            }
            pr.setRegion(textRegion.Text);
            pr.setDate(textDate.Text);
            pr.setHeaderImagePath(textBoxHeaderImage.Text);

            pr.setCsvPath(textCsv.Text);
            pr.setPrevCsvPath(textPrevCsv.Text);
            pr.setCharMapPath(textCharMap.Text);
            pr.setExclusionListPath(textExclusionList.Text);

            //note: divisionsList should be automatically updated as they are added in the form

            pr.setMainTextBrush(textBoxMainTextColour.BackColor);
            pr.setHeaderTextBrush(textBoxHeaderTextColour.BackColor);
            pr.setRegionNameBrush(textBoxRegionTextColour.BackColor);
            pr.setGameNameBrush(textBoxGameNameColour.BackColor);
            pr.setLine1Brush(textBoxLine1Colour.BackColor);
            pr.setLine2Brush(textBoxLine2Colour.BackColor);
            pr.setPlusBrush(textBoxPlusColour.BackColor);
            pr.setMinusBrush(textBoxMinusColour.BackColor);            
        }













        #endregion
    }
}
