﻿using AutoMapper;
using PrefeituraConecta.API.Negocio;
using PrefeituraConecta.MVC.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PrefeituraConecta.MVC.UI.Controllers.Declaracoes
{
    [Authorize]
    public class DeclaracoesController : Controller
    {
        // GET: Declaracoes
        Declaracoes_BS ContadorEmpresas = new Declaracoes_BS();

        public ActionResult Index()
        {
            try
            {
                var source = ContadorEmpresas.ObterContadores();

                var Contador = Mapper.Map<DeclaracoesModel>(source);

                return View(Contador);
            }
            catch
            {
                return View();
            }
           
        }

        // GET: Declaracoes/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Declaracoes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Declaracoes/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Declaracoes/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Declaracoes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Declaracoes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Declaracoes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
