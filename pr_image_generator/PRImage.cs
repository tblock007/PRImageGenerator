using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace pr_image_generator
{
    public class PRImage
    {
        #region fields

        // Header fields
        private string game;
        private string iconSet;
        private string region;
        private string date;
        private string headerImagePath;

        // Data fields
        private string csvPath;
        private string prevCsvPath;
        private string charMapPath;
        private string exclusionListPath;

        private List<string> playerList;
        private List<int> scoreList;
        private Dictionary<string, int> prevMap;
        private Dictionary<string, string> charMap;
        private HashSet<string> exclusionList;

        // Division fields
        private List<string[]> divisionsList;

        // Colour fields
        private SolidBrush mainTextBrush;
        private SolidBrush headerTextBrush;
        private SolidBrush regionNameBrush;
        private SolidBrush gameNameBrush;
        private SolidBrush line1Brush;
        private SolidBrush line2Brush;
        private SolidBrush plusBrush;
        private SolidBrush minusBrush;
        private SolidBrush diffBrush;

        // Font fields
        private Font headerFont;
        private Font dateFont;
        private Font mainFont;
        private Font diffFont;

        #endregion






        #region CONSTRUCTOR
        /**************************************************************************** 
         * CONSTRUCTOR
         * 
         * -Just the default constructor that initializes fields and hardcodes fonts
         * 
         ****************************************************************************/


        public PRImage()
        {
            game = string.Empty;
            iconSet = string.Empty;
            region = string.Empty;
            date = string.Empty;
            headerImagePath = string.Empty;

            csvPath = string.Empty;
            prevCsvPath = string.Empty;
            charMapPath = string.Empty;
            exclusionListPath = string.Empty;

            playerList = new List<string>();
            scoreList = new List<int>();
            prevMap = new Dictionary<string, int>();
            charMap = new Dictionary<string, string>();
            exclusionList = new HashSet<string>();

            divisionsList = new List<string[]>();

            mainTextBrush = new SolidBrush(Color.Black);
            headerTextBrush = new SolidBrush(Color.Black);
            regionNameBrush = new SolidBrush(Color.Black);
            gameNameBrush = new SolidBrush(Color.Black);
            line1Brush = new SolidBrush(Color.Black);
            line2Brush = new SolidBrush(Color.Black);
            plusBrush = new SolidBrush(Color.Black);
            minusBrush = new SolidBrush(Color.Black);
            diffBrush = new SolidBrush(Color.Black);

            // these Fonts will be hardcoded for now
            headerFont = new Font("Calibri", 24, FontStyle.Bold | FontStyle.Italic);
            dateFont = new Font("Calibri", 16, FontStyle.Bold | FontStyle.Italic);
            mainFont = new Font("Calibri", 20);
            diffFont = new Font("Arial", 16, FontStyle.Bold);
        }
        #endregion

        



        #region SETTER METHODS
        /**************************************************************************** 
         **************************** SETTER METHODS ********************************
         *
         * -Setter methods for the various fields
         * -Also methods for keeping the list of divisions in sync with the control
         * 
         ****************************************************************************/

        /// <summary>
        /// Sets the game.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setGame(string input)
        {
            game = input;
        }

        /// <summary>
        /// Sets the icon set.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setIconSet(string input)
        {
            iconSet = input;
        }

        /// <summary>
        /// Sets the region.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setRegion(string input)
        {
            region = input;
        }

        /// <summary>
        /// Sets the date.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setDate(string input)
        {
            date = input;
        }

        /// <summary>
        /// Sets the header image path.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setHeaderImagePath(string input)
        {
            headerImagePath = input;
        }

        /// <summary>
        /// Sets the CSV path.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setCsvPath(string input)
        {
            if (csvPath != input)
            {
                csvPath = input;
                if (csvPath != string.Empty)
                {
                    if (exclusionListPath != string.Empty)
                    {
                        parseExclusionList();
                    }
                    parseCsv();
                }
            }
        }

        /// <summary>
        /// Sets the previous CSV path.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setPrevCsvPath(string input)
        {
            if (prevCsvPath != input)
            {
                prevCsvPath = input;
                if (prevCsvPath != string.Empty)
                {
                    parsePrevCsv();
                }
            }
        }

        /// <summary>
        /// Sets the character map path.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setCharMapPath(string input)
        {
            if (charMapPath != input)
            {
                charMapPath = input;
                if (charMapPath != string.Empty)
                {
                    parseCharMap();
                }
            }
        }

        /// <summary>
        /// Sets the exclusion list path.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setExclusionListPath(string input)
        {
            if (exclusionListPath != input)
            {
                exclusionListPath = input;
                if (exclusionListPath != string.Empty)
                {
                    parseExclusionList();
                    if (csvPath != string.Empty)
                    {
                        parseCsv();
                    }
                }
            }
        }

        /// <summary>
        /// Sets the main text brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setMainTextBrush(Color input)
        {
            mainTextBrush.Color = input;
            diffBrush.Color = input; //diffBrush shares the same colour as mainTextBrush for now
        }

        /// <summary>
        /// Sets the header text brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setHeaderTextBrush(Color input)
        {
            headerTextBrush.Color = input;
        }

        /// <summary>
        /// Sets the region name brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setRegionNameBrush(Color input)
        {
            regionNameBrush.Color = input;
        }

        /// <summary>
        /// Sets the game name brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setGameNameBrush(Color input)
        {
            gameNameBrush.Color = input;
        }

        /// <summary>
        /// Sets the line1 brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setLine1Brush(Color input)
        {
            line1Brush.Color = input;
        }

        /// <summary>
        /// Sets the line2 brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setLine2Brush(Color input)
        {
            line2Brush.Color = input;
        }

        /// <summary>
        /// Sets the plus brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setPlusBrush(Color input)
        {
            plusBrush.Color = input;
        }

        /// <summary>
        /// Sets the minus brush.
        /// </summary>
        /// <param name="input">The input.</param>
        public void setMinusBrush(Color input)
        {
            minusBrush.Color = input;
        }

        #endregion





        #region DIVISIONS

        /// <summary>
        /// Adds a division to divisionsList
        /// </summary>
        /// <param name="input">Array of division parameters to be added.</param>
        public void addDivision(string[] input)
        {
            //create local copy of input so that we are sure to insert string values and not the reference to the array
            string[] local = new string[input.Length];
            for (int i = 0; i < input.Length; i = i + 1)
            {
                local[i] = input[i];
            }

            int index = 0;
            for (int i = 0; i < divisionsList.Count; i = i + 1)
            {
                if (Int32.Parse(divisionsList[i][3]) < Int32.Parse(input[3]))
                {
                    index = i;
                    break;
                }
                index = divisionsList.Count;
            }
            divisionsList.Insert(index, local);
        }

        /// <summary>
        /// Removes the division at a specified index from the divisionsList
        /// </summary>
        /// <param name="index">The index of the division to be removed.</param>
        public void removeDivision(int index)
        {
            divisionsList.RemoveAt(index);
        }

        #endregion





        #region PARSEDATA
        /**************************************************************************** 
         ***************************** PARSE METHODS ********************************
         *
         * -Parse methods to read input files and populate the lists/maps of the class      
         * -These functions take whatever is stored in the path variables; they are 
         *   called by the setter functions to automatically update the appropriate 
         *   player maps and arrays
         * 
         ****************************************************************************/


        /// <summary>
        /// Parses the CSV that specifies the data to be displayed on the image.
        /// </summary>
        private void parseCsv()
        {
            string path = csvPath;
            string line;
            string[] data;

            int playerIndex = -1;
            int scoreIndex = -1;
            bool playerQuotes = true;
            bool scoreQuotes = true;
            string player;
            string score;

            StreamReader reader;

            // empty lists
            playerList.Clear();
            scoreList.Clear();

            try
            {
                reader = new StreamReader(path);
            }
            catch
            {
                MessageBox.Show("Error parsing Import CSV: File not found.");
                return;
            }


            // read first line to find which column stores the player names and scores
            if ((line = reader.ReadLine()) != null)
            {
                data = line.Split(',');
                for (int index = 0; index < data.Length; index = index + 1)
                {
                    if (data[index].Equals("Name"))
                    {
                        playerIndex = index;
                        playerQuotes = false;
                    }
                    if (data[index].Equals(@"""Name"""))
                    {
                        playerIndex = index;
                        playerQuotes = true;
                    }
                    if (data[index].Equals("Score"))
                    {
                        scoreIndex = index;
                        scoreQuotes = false;
                    }
                    if (data[index].Equals(@"""Score"""))
                    {
                        scoreIndex = index;
                        scoreQuotes = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error parsing Import CSV: No input detected.");
            }

            if (playerIndex == -1 || scoreIndex == -1)
            {
                MessageBox.Show("Error parsing Import CSV: First row does not contain Name and/or Score header.");
            }

            // parse the rest of the lines for player and score information
            while ((line = reader.ReadLine()) != null)
            {
                data = line.Split(',');

                if (playerQuotes)
                {
                    player = data[playerIndex].Substring(1, data[playerIndex].Length - 2);
                }
                else
                {
                    player = data[playerIndex];
                }

                // if the player is to be excluded, go to the next iteration and skip the add
                if (exclusionList.Contains(player))
                {
                    continue;
                }

                if (scoreQuotes)
                {
                    score = data[scoreIndex].Substring(1, data[scoreIndex].Length - 2);
                }
                else
                {
                    score = data[scoreIndex];
                }

                // add to map
                playerList.Add(player);
                scoreList.Add(Int32.Parse(score));
            }
            reader.Close();
        }



        /// <summary>
        /// Parses the CSV that specifies the previous data, which is used to compute ELO differences
        /// </summary>
        private void parsePrevCsv()
        {
            string path = prevCsvPath;
            string line;
            string[] data;

            int playerIndex = -1;
            int scoreIndex = -1;
            bool playerQuotes = true;
            bool scoreQuotes = true;
            string player;
            string score;

            StreamReader reader;

            // empty prevMap
            prevMap.Clear();

            try
            {
                reader = new StreamReader(path);
            }
            catch
            {
                MessageBox.Show("Error parsing Previous CSV: File not found.");
                return;
            }


            // read first line to find which column stores the player names and scores
            if ((line = reader.ReadLine()) != null)
            {
                data = line.Split(',');
                for (int index = 0; index < data.Length; index = index + 1)
                {
                    if (data[index].Equals("Name"))
                    {
                        playerIndex = index;
                        playerQuotes = false;
                    }
                    if (data[index].Equals(@"""Name"""))
                    {
                        playerIndex = index;
                        playerQuotes = true;
                    }
                    if (data[index].Equals("Score"))
                    {
                        scoreIndex = index;
                        scoreQuotes = false;
                    }
                    if (data[index].Equals(@"""Score"""))
                    {
                        scoreIndex = index;
                        scoreQuotes = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Error parsing Previous CSV: No input detected.");
            }

            if (playerIndex == -1 || scoreIndex == -1)
            {
                MessageBox.Show("Error in Previous CSV: First row does not contain Name and/or Score header.");
            }

            // parse the rest of the lines for player and score information
            while ((line = reader.ReadLine()) != null)
            {
                data = line.Split(',');

                if (playerQuotes)
                {
                    player = data[playerIndex].Substring(1, data[playerIndex].Length - 2);
                }
                else
                {
                    player = data[playerIndex];
                }

                // leaving out the exclusion here... no harm in having excluded players in the map since the container sizes are small
                //if (exclusionList.Contains(player))
                //{
                //    continue;
                //}

                if (scoreQuotes)
                {
                    score = data[scoreIndex].Substring(1, data[scoreIndex].Length - 2);
                }
                else
                {
                    score = data[scoreIndex];
                }
                
                // add to map
                prevMap.Add(player, Int32.Parse(score));                
            }
            reader.Close();
        }




        /// <summary>
        /// Parses the CSV which represents the character map.
        /// </summary>
        private void parseCharMap()
        {
            string path = charMapPath;
            string line;
            string[] data;

            StreamReader reader;

            // empty charMap
            charMap.Clear();

            try
            {
                reader = new StreamReader(path);
            }
            catch
            {
                MessageBox.Show("Error parsing Character Map: File not found.");
                return;
            }

            while ((line = reader.ReadLine()) != null)
            {
                data = line.Split(',');
                try
                {
                    charMap.Add(data[0], data[1]);
                }
                catch (ArgumentException)
                {
                    MessageBox.Show(string.Format("Warning: Repeat name '{0}' in character map ignored.", data[0]));
                }                
            }
            reader.Close();
        }




        /// <summary>
        /// Parses the CSV that represents the player exclusion list.
        /// </summary>
        private void parseExclusionList()
        {
            string path = exclusionListPath;
            string line;

            StreamReader reader;

            // empty exclusionList
            exclusionList.Clear();

            try
            {
                reader = new StreamReader(path);
            }
            catch
            {
                MessageBox.Show("Error parsing Exclusion List: File not found.");
                return;
            }

            while ((line = reader.ReadLine()) != null)
            {
                //not checking for duplicates in this list - assuming inputs are reasonable, it's less costly to just add duplicates than to check for duplicates every time
                exclusionList.Add(line); //note: this assumes that the exclusion list has the format of one player per line, with no ending commas
            }
            reader.Close();

        }

        #endregion





        #region DRAWING-UPDATING
        /**************************************************************************** 
         *********************** DRAWING-UPDATING METHODS ***************************
         *
         * -drawPR is the main functionality of the class; takes the information in 
         *   the state variables and creates the image
         * -updatePreview gets an updated image and sets it in the preview picture boxes
         * -getIcon is an auxiliary method for grabbing the correct stock icon for a 
         *   given string
         * 
         ****************************************************************************/

        /// <summary>
        /// Produces the actual image that can be saved.
        /// </summary>
        /// <returns>The resulting image.</returns>
        public Image drawPR()
        {
            //create image
            int numLines = playerList.Count + divisionsList.Count;
            int rowWidth = 750;
            int rowHeight = 35;
            int height = 150 + rowHeight * (numLines);
            Bitmap bmap = new Bitmap(rowWidth, height);
            Graphics g = Graphics.FromImage(bmap);
            Color divBgColor;
            Color divTextColor;
            int red, green, blue;

            //draw header
            StringFormat updateFormat = new StringFormat();
            updateFormat.Alignment = StringAlignment.Far;

            g.DrawImage(Image.FromFile(headerImagePath), new Point(0, 0));
            if (region != String.Empty)
            {
                g.DrawString("Division - ", headerFont, headerTextBrush, new Point(12, 60));
                g.DrawString(region, headerFont, regionNameBrush, new Point(150, 60));
            }
            if (game != String.Empty)
            {
                g.DrawString(game, headerFont, gameNameBrush, new Point(12, 100));
            }
            if (date != String.Empty)
            {
                g.DrawString("Updated " + date, dateFont, headerTextBrush, new RectangleF(300, 122, 445, 28), updateFormat);
            }

            //this is the main drawing loop
            //for each player that was parsed, we are going to first check if a division header should be placed, and then draw the player line
            //once we complete this loop, the image should be completely generated

            int prevElo;
            int difference;            
            string pointsDifference = " -";

            string temp_characters;
            string[] playerCharacters;

            Point rankPoint;
            Point diffPoint;
            Point namePoint;
            Point pointsPoint;
            Point charactersPoint;

            
            int y = 151; // set initial y value to just underneath the header
            int lineIndex = 0;
            int divisionRank = 1;
            int divisionsListIndex = 0;

            for (int i = 0; i < playerList.Count; i = i + 1)
            {
                // place division if ELO values say it is appropriate
                if (divisionsListIndex <= (divisionsList.Count - 1))
                {
                    if (Int32.Parse(divisionsList[divisionsListIndex][3]) > scoreList[i])
                    {
                        rankPoint = new Point(15, y);
                        Rectangle divBgRectangle = new Rectangle(0, y - 1, rowWidth, rowHeight);

                        //get background and text color for division header
                        red = Convert.ToInt32(divisionsList[divisionsListIndex][2].Substring(0, 2), 16);
                        green = Convert.ToInt32(divisionsList[divisionsListIndex][2].Substring(2, 2), 16);
                        blue = Convert.ToInt32(divisionsList[divisionsListIndex][2].Substring(4, 2), 16);
                        divBgColor = Color.FromArgb(red, green, blue);

                        red = Convert.ToInt32(divisionsList[divisionsListIndex][1].Substring(0, 2), 16);
                        green = Convert.ToInt32(divisionsList[divisionsListIndex][1].Substring(2, 2), 16);
                        blue = Convert.ToInt32(divisionsList[divisionsListIndex][1].Substring(4, 2), 16);
                        divTextColor = Color.FromArgb(red, green, blue);
                        
                        g.FillRectangle(new SolidBrush(divBgColor), divBgRectangle);
                        g.DrawString(divisionsList[divisionsListIndex][0], mainFont, new SolidBrush(divTextColor), rankPoint);

                        //update index and coordinates; set divisionRank back to 1
                        divisionRank = 1;
                        lineIndex = lineIndex + 1;
                        divisionsListIndex = divisionsListIndex + 1;
                        y = y + rowHeight;

                        //go back and check next division; otherwise, in the rare case that there is nobody in a division, one player will be misplaced
                        i = i - 1;
                        continue;
                    }
                }

                // draw player line
                // first get playerCharacters string[]
                if (charMap.TryGetValue(playerList[i], out temp_characters))
                {
                    playerCharacters = temp_characters.Split('/');
                }
                else
                {
                    playerCharacters = new string[0];
                }
                
                // determine ELO difference
                if (prevMap.TryGetValue(playerList[i], out prevElo))
                {                                        
                    difference = Math.Abs(prevElo - scoreList[i]);

                    // set brush and text based on ELO difference
                    if (prevElo < scoreList[i])
                    {
                        pointsDifference = "+" + difference.ToString();
                        diffBrush = plusBrush;
                    }
                    else if (prevElo > scoreList[i])
                    {
                        pointsDifference = "-" + difference.ToString();
                        diffBrush = minusBrush;
                    }
                    else if (prevElo == scoreList[i])
                    {
                        pointsDifference = " -";
                        diffBrush = mainTextBrush;
                    }
                }
                else
                {
                    pointsDifference = " *";
                    diffBrush = mainTextBrush;
                }
                
                // do the actual drawing
                rankPoint = new Point(15, y);
                diffPoint = new Point(100, y + 5);
                namePoint = new Point(190, y);
                pointsPoint = new Point(450, y);
                charactersPoint = new Point(560, y);

                Rectangle bgRectangle = new Rectangle(0, y - 1, rowWidth, rowHeight);
                if (lineIndex % 2 == 0)
                {
                    g.FillRectangle(line1Brush, bgRectangle);
                }
                else
                {
                    g.FillRectangle(line2Brush, bgRectangle);
                }
                g.DrawString(divisionRank.ToString(), mainFont, mainTextBrush, rankPoint);
                g.DrawString(pointsDifference, diffFont, diffBrush, diffPoint);
                g.DrawString(playerList[i], mainFont, mainTextBrush, namePoint);
                g.DrawString(scoreList[i].ToString(), mainFont, mainTextBrush, pointsPoint);

                foreach (string character in playerCharacters)
                {
                    g.DrawImage(getIcon(character, iconSet), charactersPoint);
                    charactersPoint.Offset(rowHeight, 0); //we use rowHeight for dx because each characters gets a square space
                }
                divisionRank = divisionRank + 1;

                y = y + rowHeight;
                lineIndex = lineIndex + 1;


            }

            return (Image) bmap;
        }



        /// <summary>
        /// Updates the previews in the UI.
        /// </summary>
        /// <param name="previews">The PictureBoxes to be updated with the preview.</param>
        public void updatePreview(PictureBox[] previews)
        {
            Image drawnPR = drawPR();
            double aspectRatio = (double) drawnPR.Size.Height / (double) drawnPR.Size.Width;

            foreach (PictureBox p in previews)
            {
                p.Image = (Image)new Bitmap(drawnPR, new Size(441, Convert.ToInt32(441 * aspectRatio)));
            }
        }



        /// <summary>
        /// Retrieves the character icon from the appropriate file.
        /// </summary>
        /// <param name="character">The character whose icon is to be retrieved.</param>
        /// <param name="set">The set of icons from which to retrieve the icon.</param>
        /// <returns>The icon image.</returns>
        private Image getIcon(string character, string set)
        {
            if (set == "Melee")
            {
                switch (character)
                {
                    case "DrMario":
                    case "Doc":
                        return Image.FromFile("images/MstockDoc.png");
                    case "Mario":
                        return Image.FromFile("images/MstockMario.png");
                    case "Luigi":
                        return Image.FromFile("images/MstockLuigi.png");
                    case "Bowser":
                        return Image.FromFile("images/MstockBowser.png");
                    case "Peach":
                        return Image.FromFile("images/MstockPeach.png");
                    case "Yoshi":
                        return Image.FromFile("images/MstockYoshi.png");
                    case "DonkeyKong":
                    case "DK":
                        return Image.FromFile("images/MstockDK.png");
                    case "CaptainFalcon":
                    case "CFalcon":
                    case "Falcon":
                    case "CF":
                        return Image.FromFile("images/MstockFalcon.png");
                    case "Ganondorf":
                    case "Ganon":
                        return Image.FromFile("images/MstockGanondorf.png");
                    case "Falco":
                        return Image.FromFile("images/MstockFalco.png");
                    case "Fox":
                        return Image.FromFile("images/MstockFox.png");
                    case "Ness":
                        return Image.FromFile("images/MstockNess.png");
                    case "IceClimbers":
                    case "ICs":
                    case "Popo":
                        return Image.FromFile("images/MstockIceclimbers.png");
                    case "Kirby":
                        return Image.FromFile("images/MstockKirby.png");
                    case "Samus":
                        return Image.FromFile("images/MstockSamus.png");
                    case "Zelda":
                        return Image.FromFile("images/MstockZelda.png");
                    case "Sheik":
                        return Image.FromFile("images/MstockSheik.png");
                    case "Link":
                        return Image.FromFile("images/MstockLink.png");
                    case "YoungLink":
                    case "YLink":
                    case "YL":
                        return Image.FromFile("images/MstockYlink.png");
                    case "Pichu":
                        return Image.FromFile("images/MstockPichu.png");
                    case "Pikachu":
                        return Image.FromFile("images/MstockPikachu.png");
                    case "Jigglypuff":
                    case "Jiggs":
                    case "Puff":
                        return Image.FromFile("images/MstockJigglypuff.png");
                    case "Mewtwo":
                        return Image.FromFile("images/MstockMewtwo.png");
                    case "GW":
                    case "GameandWatch":
                    case "MrGameandWatch":
                    case "GaW":
                        return Image.FromFile("images/MstockGw.png");
                    case "Marth":
                        return Image.FromFile("images/MstockMarth.png");
                    case "Roy":
                        return Image.FromFile("images/MstockRoy.png");
                    case "GigaBowser":
                        return Image.FromFile("images/MstockGigabowser.png");
                    case "MasterHand":
                        return Image.FromFile("images/MstockMasterhand.png");
                    case "Sandbag":
                        return Image.FromFile("images/stockSandbag.png");
                    case "Random":
                        return Image.FromFile("images/stockRandom.png");
                    default:
                        if (File.Exists("images/" + character + ".png"))
                        {
                            return Image.FromFile("images/" + character + ".png");
                        }
                        return Image.FromFile("images/MstockSmash.png");
                }
            }
            if (set == "Brawl/PM")
            {
                switch (character)
                {
                    case "DrMario":
                    case "Doc":
                        return Image.FromFile("images/MstockDoc.png");
                    case "Mario":
                        return Image.FromFile("images/BstockMario.png");
                    case "Luigi":
                        return Image.FromFile("images/BstockLuigi.png");
                    case "Bowser":
                        return Image.FromFile("images/BstockBowser.png");
                    case "Peach":
                        return Image.FromFile("images/BstockPeach.png");
                    case "Yoshi":
                        return Image.FromFile("images/BstockYoshi.png");
                    case "DonkeyKong":
                    case "DK":
                        return Image.FromFile("images/BstockDK.png");
                    case "CaptainFalcon":
                    case "CFalcon":
                    case "Falcon":
                    case "CF":
                        return Image.FromFile("images/BstockFalcon.png");
                    case "Ganondorf":
                    case "Ganon":
                        return Image.FromFile("images/BstockGanondorf.png");
                    case "Falco":
                        return Image.FromFile("images/BstockFalco.png");
                    case "Fox":
                        return Image.FromFile("images/BstockFox.png");
                    case "Ness":
                        return Image.FromFile("images/BstockNess.png");
                    case "IceClimbers":
                    case "ICs":
                    case "Popo":
                        return Image.FromFile("images/BstockIceclimbers.png");
                    case "Kirby":
                        return Image.FromFile("images/BstockKirby.png");
                    case "Samus":
                        return Image.FromFile("images/BstockSamus.png");
                    case "Zelda":
                        return Image.FromFile("images/BstockZelda.png");
                    case "Sheik":
                        return Image.FromFile("images/BstockSheik.png");
                    case "Link":
                        return Image.FromFile("images/BstockLink.png");
                    case "ToonLink":
                    case "TLink":
                    case "TL":
                        return Image.FromFile("images/BstockToonlink.png");
                    case "YoungLink":
                    case "YLink":
                    case "YL":
                        return Image.FromFile("images/MstockYlink.png");
                    case "PT":
                    case "PokemonTrainer":
                        return Image.FromFile("images/BstockPT.png");
                    case "Pichu":
                        return Image.FromFile("images/MstockPichu.png");
                    case "Pikachu":
                        return Image.FromFile("images/BstockPikachu.png");
                    case "Jigglypuff":
                    case "Jiggs":
                    case "Puff":
                        return Image.FromFile("images/BstockJigglypuff.png");
                    case "Mewtwo":
                        return Image.FromFile("images/MstockMewtwo.png");
                    case "GW":
                    case "GameandWatch":
                    case "MrGameandWatch":
                    case "GaW":
                        return Image.FromFile("images/BstockGw.png");
                    case "Marth":
                        return Image.FromFile("images/BstockMarth.png");
                    case "Roy":
                        return Image.FromFile("images/MstockRoy.png");
                    case "Charizard":
                        return Image.FromFile("images/BstockCharizard.png");
                    case "Dedede":
                    case "D3":
                    case "KingDedede":
                        return Image.FromFile("images/BstockDedede.png");
                    case "Diddy":
                    case "DiddyKong":
                        return Image.FromFile("images/BstockDiddy.png");
                    case "Ike":
                        return Image.FromFile("images/BstockIke.png");
                    case "Ivy":
                    case "Ivysaur":
                        return Image.FromFile("images/BstockIvysaur.png");
                    case "Lucario":
                        return Image.FromFile("images/BstockLucario.png");
                    case "Lucas":
                        return Image.FromFile("images/BstockLucas.png");
                    case "MK":
                    case "Metaknight":
                    case "MetaKnight":
                        return Image.FromFile("images/BstockMetaknight.png");
                    case "Olimar":
                        return Image.FromFile("images/BstockOlimar.png");
                    case "Pit":
                        return Image.FromFile("images/BstockPit.png");
                    case "Rob":
                    case "ROB":
                        return Image.FromFile("images/BstockRob.png");
                    case "Snake":
                        return Image.FromFile("images/BstockSnake.png");
                    case "Sonic":
                        return Image.FromFile("images/BstockSonic.png");
                    case "Squirtle":
                        return Image.FromFile("images/BstockSquirtle.png");
                    case "Wario":
                        return Image.FromFile("images/BstockWario.png");
                    case "Wolf":
                        return Image.FromFile("images/BstockWolf.png");
                    case "ZSS":
                    case "ZeroSuitSamus":
                        return Image.FromFile("images/BstockZerosuit.png");
                    case "GigaBowser":
                        return Image.FromFile("images/MstockGigabowser.png");
                    case "MasterHand":
                        return Image.FromFile("images/MstockMasterhand.png");
                    case "Sandbag":
                        return Image.FromFile("images/stockSandbag.png");
                    case "Random":
                        return Image.FromFile("images/stockRandom.png");
                    default:
                        if (File.Exists("images/" + character + ".png"))
                        {
                            return Image.FromFile("images/" + character + ".png");
                        }
                        return Image.FromFile("images/MstockSmash.png");
                }
            }
            if (set == "Smash 4")
            {
                string[] parsed = character.Split('_');
                string icon;
                string palette;

                switch (parsed[0])
                {
                    case "Mario":
                        icon = "DstockMario";
                        break;
                    case "Luigi":
                        icon = "DstockLuigi";
                        break;
                    case "Peach":
                        icon = "DstockPeach";
                        break;
                    case "Bowser":
                    case "Koopa":
                        icon = "DstockBowser";
                        break;
                    case "Yoshi":
                        icon = "DstockYoshi";
                        break;
                    case "Rosalina":
                    case "Rosetta":
                    case "RosalinaandLuma":
                    case "Rosaluma":
                        icon = "DstockRosalina";
                        break;
                    case "BowserJr":
                    case "BJ":
                    case "KoopaKid":
                        icon = "DstockBowserjr";
                        break;
                    case "Wario":
                        icon = "DstockWario";
                        break;
                    case "GW":
                    case "GameandWatch":
                    case "MrGameandWatch":
                    case "GaW":
                        icon = "DstockGw";
                        break;
                    case "DonkeyKong":
                    case "DK":
                        icon = "DstockDK";
                        break;
                    case "Diddy":
                    case "DiddyKong":
                        icon = "DstockDiddy";
                        break;
                    case "Link":
                        icon = "DstockLink";
                        break;
                    case "Zelda":
                        icon = "DstockZelda";
                        break;
                    case "Sheik":
                        icon = "DstockSheik";
                        break;
                    case "Ganondorf":
                    case "Ganon":
                        icon = "DstockGanondorf";
                        break;
                    case "ToonLink":
                    case "TL":
                    case "TLink":
                        icon = "DstockToonlink";
                        break;
                    case "Samus":
                        icon = "DstockSamus";
                        break;
                    case "ZSS":
                    case "ZeroSuit":
                    case "ZeroSuitSamus":
                        icon = "DstockZerosuit";
                        break;
                    case "Pit":
                        icon = "DstockPit";
                        break;
                    case "Palutena":
                        icon = "DstockPalutena";
                        break;
                    case "Marth":
                        icon = "DstockMarth";
                        break;
                    case "Ike":
                        icon = "DstockIke";
                        break;
                    case "Robin":
                    case "Reflet":
                        icon = "DstockRobin";
                        break;
                    case "Kirby":
                        icon = "DstockKirby";
                        break;
                    case "KingDedede":
                    case "Dedede":
                    case "D3":
                        icon = "DstockDedede";
                        break;
                    case "MK":
                    case "Metaknight":
                    case "MetaKnight":
                        icon = "DstockMetaknight";
                        break;
                    case "LittleMac":
                    case "LilMac":
                    case "Mac":
                        icon = "DstockMac";
                        break;
                    case "Fox":
                        icon = "DstockFox";
                        break;
                    case "Falco":
                        icon = "DstockFalco";
                        break;
                    case "Pikachu":
                        icon = "DstockPikachu";
                        break;
                    case "Charizard":
                    case "Zard":
                    case "Lizardon":
                        icon = "DstockCharizard";
                        break;
                    case "Lucario":
                        icon = "DstockLucario";
                        break;
                    case "Jigglypuff":
                    case "Jiggs":
                    case "Puff":
                    case "Purin":
                        icon = "DstockJigglypuff";
                        break;
                    case "Greninja":
                    case "Gekkouga":
                        icon = "DstockGreninja";
                        break;
                    case "Duckhunt":
                    case "DuckHunt":
                    case "DuckHuntDuo":
                        icon = "DstockDuckhunt";
                        break;
                    case "Rob":
                    case "ROB":
                        icon = "DstockRob";
                        break;
                    case "Ness":
                        icon = "DstockNess";
                        break;
                    case "CaptainFalcon":
                    case "CFalcon":
                    case "Falcon":
                    case "CF":
                        icon = "DstockFalcon";
                        break;
                    case "Villager":
                        icon = "DstockVillager";
                        break;
                    case "Olimar":
                    case "CaptainOlimar":
                    case "PikminandOlimar":
                        icon = "DstockOlimar";
                        break;
                    case "WiiFit":
                    case "WiiFitTrainer":
                        icon = "DstockWiifit";
                        break;
                    case "DrMario":
                    case "Doc":
                        icon = "DstockDoc";
                        break;
                    case "DarkPit":
                        icon = "DstockDarkpit";
                        break;
                    case "Lucina":
                        icon = "DstockLucina";
                        break;
                    case "Shulk":
                        icon = "DstockShulk";
                        break;
                    case "Pacman":
                        icon = "DstockPacman";
                        break;
                    case "Megaman":
                        icon = "DstockMegaman";
                        break;
                    case "Sonic":
                        icon = "DstockSonic";
                        break;
                    case "Mii":
                        icon = "DstockMii";
                        break;
                    case "Miibrawler":
                    case "MiiBrawler":
                        icon = "DstockMiibrawler";
                        break;
                    case "Miigunner":
                    case "MiiGunner":
                        icon = "DstockMiigunner";
                        break;
                    case "Miiswordfighter":
                    case "MiiSwordfighter":
                    case "Miisword":
                    case "MiiSword":
                        icon = "DstockMiiswordfighter";
                        break;
                    case "Sandbag":
                        icon = "DstockSandbag";
                        break;
                    case "Random":
                        icon = "DstockRandom";
                        break;
                    default:
                        //if any other case, either straight-up return the custom image, or return the default symbol
                        if (File.Exists("images/" + character + ".png"))
                        {
                            return Image.FromFile("images/" + character + ".png");
                        }
                        return Image.FromFile("images/MstockSmash.png");
                }

                //parsing only gets to this point if a valid character was entered (ie- not a custom image or incorrect name)
                if (parsed.Length == 2)
                {
                    if (File.Exists("images/" + icon + "_" + parsed[1] + ".png"))
                    {
                        palette = "_" + parsed[1];
                    }
                    else
                    {
                        palette = "_1"; //if anything wrong, just return the default palette
                    }
                }
                else
                {
                    palette = "_1"; //if palette not specified, return default palette
                }

                return Image.FromFile("images/" + icon + palette + ".png");
            }

            //catch-all return for all games
            return Image.FromFile("images/MstockSmash.png");
        }

        #endregion
    }
}