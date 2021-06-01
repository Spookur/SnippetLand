using CMS.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CMS.Controllers
{
    public class CaseController : Controller
    {
        // GET: Case
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<CaseModel>("CaseViewAll"));
        }


        // ... /Employee/AddOrEdit - insert
        // ... /Employee/AddOrEdit/id
        [HttpGet]
        public ActionResult AddOrEdit(int id=0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@CaseId", id);
                return View(DapperORM.ReturnList<CaseModel>("CaseViewById", param).FirstOrDefault<CaseModel>());
            }
                
           
        }

        [HttpPost]
        public ActionResult AddOrEdit(CaseModel caseModel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CaseId", caseModel.CaseId);
            param.Add("@Details", caseModel.Details);
            param.Add("@FilingDate", caseModel.FilingDate);
            param.Add("@Agency", caseModel.Agency);
            param.Add("@DefendantName", caseModel.DefendantName);
            param.Add("@DefendantAddress", caseModel.DefendantAddress);
            param.Add("@Charges", caseModel.Charges);
            DapperORM.ExecuteWithoutReturn("CaseAddOrEdit", param);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CaseId", id);
            DapperORM.ExecuteWithoutReturn("CaseDeleteById", param);
            return RedirectToAction("Index");
        }
    }
}