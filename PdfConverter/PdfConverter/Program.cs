using System.IO;

public class PdfcrowdTest
{
    static void Main()
    {
        try
        {
            FileStream fileStream;

            // create an API client instance
            pdfcrowd.Client client = new pdfcrowd.Client("egor", "281dcd338e127d30472ea7e82b77ccad");

            // convert a web page and save the PDF to a file
            //fileStream = new FileStream("google_com.pdf", FileMode.CreateNew);
            //client.convertURI("http://www.google.com", fileStream);
            //fileStream.Close();

            //// convert an HTML string and store the PDF into a memory stream
            //MemoryStream memStream = new MemoryStream();
            //string html = "<head></head><body>My HTML Layout</body>";
            //client.convertHtml(html, memStream);

            // convert an HTML file
            fileStream = new FileStream(@"C:\Users\Egor\Desktop\cv\resume.pdf", FileMode.CreateNew);
            client.convertFile(@"C:\Users\Egor\Desktop\cv\resume.html", fileStream);
            fileStream.Close();

            // retrieve the number of tokens in your account
            //int ntokens = client.numTokens();
        }
        catch (pdfcrowd.Error why)
        {
            System.Console.WriteLine(why.ToString());
        }
    }
}