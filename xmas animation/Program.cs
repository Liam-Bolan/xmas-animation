using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace xmas_animation
{
    class Program
    {
        static Int32 HexToDecimal(char hexValue)
        {
            int DecimalValue;
            switch (hexValue)
            {
                case 'A': DecimalValue = 10;
                    break;
                case 'B': DecimalValue = 11;
                    break;
                case 'C': DecimalValue = 12;
                    break;
                case 'D': DecimalValue = 13;
                    break;
                case 'E': DecimalValue = 14;
                    break;
                case 'F': DecimalValue = 15;
                    break;
                default: DecimalValue = hexValue - 48; //subtract 48 from ascii code
                    break;
            }
            return DecimalValue;

        }

        static void Main(string[] args)
        {
            /* Ho, Ho Ho,
             * Welcome to the xmas animation challenge
             * 
             * you have a file called 'xmasanimation.txt' text file in this project
             * It has the following format
             * 
             * METADATA
             * first line frame height
             * second line frame width
             * third line number of frames
             * fouth line frame rate (frames per second)
             * 
             * then comes the frame data. Each 'pixel' is stored as a hexadecimal digit
             * to display a pixel set the background colour to the pixel colour and write a space
             * don't forget a writeline after each row!
             * 
             * Too difficult? then try replacing between the ------------ lines with the text in the 
             * 'half Solution' text file
             * 
             * 
             * 
             * Good Luck!
             */

            //-----------------------------------------------------------------------------------------------------------
            // 1. Create variables to store height, width, framecount and framerate

            int height = 0;
            int width = 0;
            int framecount = 0;
            int framerate = 0;

            // 2. create a streamreader to access the xamsanimation.txt file

            StreamReader xmasanimation = new StreamReader("xmasanimation.txt");

            //3. Read in the first four lines of the text file and get values for the variables you created in 1.

            xmasanimation.ReadLine();
            xmasanimation.ReadLine();
            xmasanimation.ReadLine();
            xmasanimation.ReadLine();

            //4. Create a for loop to read each frame in the animation file

            for (int i = 0; i < framecount; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    string row = xmasanimation.ReadLine();
                    
                }
            }
            
          
                //5. Create a nested for loop inside the loop in 4. to process each row in a frame
             
                      //6. read a row of data in the loop into a string variable
                   
                      // 7. create another nested FOR loop inside the loop in 5. to process each pixel in each row.
               
                            //8. Convert each character in the string to its decimal value :- use the function HextoDecimal
                      
                            //9. Set console color using :-console.backgroundcolor=(ConsoleColor)pixelvalue
                            // write a space onto the console.
                   
                     // 10. writeline - start a new row after the inner loop has finished
          
                 //11. Pause between frames after the second loop using :- System.Threading.Thread.Sleep(1000/framerate)

                //12.After the pause set the background color to black and clear the screen


            //13. close the stream reader after all the loops have finished

            //----------------------------------------------------------------------------------------------------------


        }
    }
}
