using Dapper;
using PokemonManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokemonManager.Controllers
{
    public class PokemonController : Controller
    {
        // GET: Pokemon
        public ActionResult Index()
        {
            return View(DapperORM.ReturnList<PokemonModel>("PokemonViewAll"));
        }

        [HttpGet]
        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View();
            else
            {
                DynamicParameters param = new DynamicParameters();
                param.Add("@PokemonID", id);
                return View(DapperORM.ReturnList<PokemonModel>("PokemonViewByID", param).FirstOrDefault<PokemonModel>());
            }


        }

        [HttpPost]
        public ActionResult AddOrEdit(PokemonModel pokeModel)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@CaseId", pokeModel.PokemonID);
            param.Add("@Details", pokeModel.PokemonName);
            param.Add("@FilingDate", pokeModel.PokemonType);
            param.Add("@Agency", pokeModel.Rarity);
            param.Add("@DefendantName", pokeModel.IMGFilePath);
            
            DapperORM.ExecuteWithoutReturn("PokemonAddOrEdit", param);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            DynamicParameters param = new DynamicParameters();
            param.Add("@PokemonID", id);
            DapperORM.ExecuteWithoutReturn("PokemonDeleteByID", param);
            return RedirectToAction("Index");
        }
    }
}