using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        ProjectDBContext dc = new ProjectDBContext();
        #region display project
        public ActionResult DisplayProjects()
        {
            return View(dc.projects);
        }
        #endregion

        #region add
        [HttpGet]
        public ViewResult AddProject()
        {
            return View();
        }
        [HttpPost]
        public RedirectToRouteResult AddProject(Project project, HttpPostedFileBase file)
        {

            if (file != null)
            {
                //Checking whether the folder "Uploads" is exists or not and creating it if not exists
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                {
                    Directory.CreateDirectory(PhysicalPath);
                }
                file.SaveAs(PhysicalPath + file.FileName);
                project.ProjectImage = file.FileName;
            }


            dc.projects.Add(project);
            dc.SaveChanges();
            return RedirectToAction("Admin");
        }
        #endregion

        #region detele
        public RedirectToRouteResult Delete(int id)
        {
            var d = dc.projects.Find(id);
            dc.projects.Remove(d);
            dc.SaveChanges();
            return RedirectToAction("Admin");
        }
        #endregion

        #region Admin
        
        public ViewResult Admin()
        {
            return View(dc.projects);
        }
        #endregion

        #region edit
        [HttpGet]
        public ViewResult Edit(int id)
        {
            return View(dc.projects.Find(id));
        }
        [HttpPost]
        public RedirectToRouteResult Edit(int id,Project project, HttpPostedFileBase file)
        {

            if (file != null)
            {
                //Checking whether the folder "Uploads" is exists or not and creating it if not exists
                string PhysicalPath = Server.MapPath("~/Uploads/");
                if (!Directory.Exists(PhysicalPath))
                {
                    Directory.CreateDirectory(PhysicalPath);
                }
                file.SaveAs(PhysicalPath + file.FileName);
                project.ProjectImage = file.FileName;
            }
            var v = dc.projects.Find(id);
            if (file == null)
            {
                project.ProjectImage = v.ProjectImage;

            }
           
            dc.projects.Remove(v);
            dc.projects.Add(project);
            dc.SaveChanges();
            
            return RedirectToAction("Admin", routeValues: new Message());
        }
        #endregion
    }
}