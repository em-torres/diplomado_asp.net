using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NanoStore.Helpers
{
    public class ImgHelper
    {
        protected void ConvertImg(string imgPath)
        {
            //// Specify the path on the server
            //string savePath = @"c:\uploads\";

            //savePath += imgPath;

            //    // Call the SaveAs method to save the 
            //    // uploaded file to the specified path.
            //    // This example does not perform all
            //    // the necessary error checking.               
            //    // If a file with the same name
            //    // already exists in the specified path,  
            //    // the uploaded file overwrites it.
            //    FileUpload1.SaveAs(savePath);

            //    // Notify the user that the file was uploaded successfully.
            //    UploadStatusLabel.Text = "Your file was uploaded successfully.";

            //    // Call a helper routine to display the contents
            //    // of the file to upload.
            //    DisplayFileContents(FileUpload1.PostedFile);
            //}
            //else
            //{
            //    // Notify the user that a file was not uploaded.
            //    UploadStatusLabel.Text = "You did not specify a file to upload.";
            //}
        }
        private void DisplayFileContents(HttpPostedFile file)
        {
            //int fileLen;
            //string displayString = "";

            //// Get the length of the file.
            //fileLen = FileUpload1.PostedFile.ContentLength;

            //// Display the length of the file in a label.
            //LengthLabel.Text = "The length of the file is "
            //                   + fileLen.ToString() + " bytes.";

            //// Create a byte array to hold the contents of the file.
            //byte[] input = new byte[fileLen - 1];
            //input = FileUpload1.FileBytes;

            //// Copy the byte array to a string.
            //for (int loop1 = 0; loop1 < fileLen; loop1++)
            //{
            //    displayString = displayString + input[loop1].ToString();
            //}

            //// Display the contents of the file in a 
            //// textbox on the page.
            //ContentsLabel.Text = "The contents of the file as bytes:";

            //TextBox ContentsTextBox = new TextBox();
            //ContentsTextBox.TextMode = TextBoxMode.MultiLine;
            //ContentsTextBox.Height = Unit.Pixel(300);
            //ContentsTextBox.Width = Unit.Pixel(400);
            //ContentsTextBox.Text = displayString;

            //// Add the textbox to the Controls collection
            //// of the Placeholder control.
            //PlaceHolder1.Controls.Add(ContentsTextBox);
        }
    }
}