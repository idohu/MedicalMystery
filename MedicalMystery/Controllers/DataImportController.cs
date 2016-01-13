using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MedicalMystery.Controllers
{
    public class DataImportController : Controller
    {
        // GET: DataImport
        
        public ActionResult Index(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
                try
                {
                    var reader = new StreamReader(file.InputStream);
                    var line = reader.ReadLine();
                    line = reader.ReadLine();
                    line = line.Remove(line.Length - 1);
                    var values = line.Split(',');
                    DataTable dt = new DataTable(file.FileName);
                    foreach (string s in values)
                    {
                        dt.Columns.Add(new DataColumn(s));
                    }
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        line = line.Remove(line.Length - 1);
                        values = line.Split(',');
                        DataRow row = dt.NewRow();
                        for (int i = 0; i < values.Length; i++)
                        {
                            row[i] = values[i];
                        }
                        dt.Rows.Add(row);
                    }
                    ViewBag.Message = "File uploaded successfully";
                    return View(dt);
                }
                catch (Exception ex)
                {
                    ViewBag.Message = "ERROR:" + ex.Message.ToString();
                }
            else
            {
                ViewBag.Message = "You have not specified a file.";
            }
            return View();
        }
    }

}