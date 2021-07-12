using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EFinMVC.Models;
using System.Web.Mvc;

namespace EFinMVC.Controllers
{
    public class GroupController : Controller
    {
        // GET: Group
        public ActionResult Index()
        {
            //create object of DbContext class
            GroupDBEntities2 dd = new GroupDBEntities2();
            //now put that in list of Group
            //ToList returns a new list
            //Groups.ToList to convert collection of data into
            List<Group> lg = dd.Groups.ToList();
            return View(lg);
        }

        //now applying the concept of action link
        //We want to display all the gname in a bulleted list n When we click on the above name hyperlink, then we need to redirect to the Group details page where we will display the full details of the Group

        //for this, we will create method having id
        public ActionResult GroupDetail(int myid)     //passing id as parameter
        {
            //create object of DbContext class
            GroupDBEntities2 dd = new GroupDBEntities2();

            Group gg = dd.Groups.Single(x => x.Id == myid);

            return View(gg);
        }
    }
}
    //Single	Returns the only element from a collection, or the only element that satisfies a condition. 
