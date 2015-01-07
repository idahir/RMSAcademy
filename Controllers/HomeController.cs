using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;
using RMSAcademy.Models;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure;

namespace RMSAcademy.Controllers
{


    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
          
            return View();
        }
        public ActionResult Principal()
        {
            return View();
        }
        public ActionResult Parents()
        {
            return View();
        }
        public ActionResult Sponsor()
        {
            return View();
        }
        public ActionResult Staff()
        {
            //var staff  = GetStaff();
            return View();
        }

        //private List<Staff> GetStaff()
        //{
        //    //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
        //    //    CloudConfigurationManager.GetSetting("StorageConnectionString"));

        //    //// Create the blob client.
        //    //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

        //    //// Retrieve a reference to a container. 
        //    //CloudBlobContainer container = blobClient.GetContainerReference("RMSA");

        //    //// Create the container if it doesn't already exist.
        //    //container.CreateIfNotExists();

        //    //container.SetPermissions(
        //    //  new BlobContainerPermissions
        //    //{
        //    //     PublicAccess =
        //    //BlobContainerPublicAccessType.Blob
        //    //});


        //    //// Retrieve storage account from connection string.
        //    //CloudStorageAccount storageAccount = CloudStorageAccount.Parse(
        //    //    CloudConfigurationManager.GetSetting("StorageConnectionString"));

        //    //// Create the blob client.
        //    //CloudBlobClient blobClient = storageAccount.CreateCloudBlobClient();

        //    //// Retrieve reference to a previously created container.
        //    //CloudBlobContainer container = blobClient.GetContainerReference("mycontainer");

        //    //// Retrieve reference to a blob named "myblob".
        //    //CloudBlockBlob blockBlob = container.GetBlockBlobReference("myblob");

        //    //// Create or overwrite the "myblob" blob with contents from a local file.
        //    //using (var fileStream = System.IO.File.OpenRead(@"path\myfile"))
        //    //{
        //    //    blockBlob.UploadFromStream(fileStream);
        //    //} 

        //    string fileName  = HttpContext.Server.MapPath("~//Docs/StaffContactInformation.xlsx");
        //    var app = new Application();
       

        //    //open workbook
        //    var workbook = app.Workbooks.Open(fileName, Type.Missing);

        //    //select sheet
        //    var workSheet = (Worksheet)workbook.Worksheets[1];

        //    Range excelRange = workSheet.UsedRange;

        //    //get an object array of all of the cells in the worksheet (their values)
        //    object[,] valueArray = (object[,])excelRange.get_Value(XlRangeValueDataType.xlRangeValueDefault);


        //    //access the cells

        //    //foreach (var item in valueArray)
        //    //{
        //    //      Debug.Print(item.ToString());
            
        //    //}
        //    var staffList = new List<Staff>();
        //    Staff staff = null;
        //    for (int row = 1; row <= workSheet.UsedRange.Rows.Count; ++row)
        //    {
        //        staff = new Staff();
        //        for (int col = 1; col <= workSheet.UsedRange.Columns.Count; ++col)
        //        {
        //            //access each cell

        //            if (valueArray[row, col] == null)
        //            {
        //                break;
        //            }
        //            if (string.IsNullOrEmpty(staff.Name))
        //            {
        //               staff.Name = valueArray[row, col].ToString();
        //               continue;
        //            }
                    
        //            if (string.IsNullOrEmpty(staff.Position))
        //            {
        //                staff.Position = valueArray[row, col].ToString();
        //                continue;
        //            }

        //            staff.Email = valueArray[row, col] != null ? valueArray[row, col].ToString(): null;
        //            //Debug.Print(valueArray[row, col].ToString());
        //        }
        //          staffList.Add(staff);
        //    }

        //    //clean up st
        //    return staffList;


        //}
         public ActionResult FAQ()
        {
             return View();
        }
        public ActionResult Links()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
        public ActionResult ELL()
        {
            return View();
        }
        public ActionResult Board()
        {
            return View();
        }
        public ActionResult Calendar()
        {
            return View();
        }
        public ActionResult Documents()
        {
            return View();
        }
        public ActionResult SchoolNews()
        {
            return View();
        }

 
    }


}