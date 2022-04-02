using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entities;
using Infraestructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBMVC.Models;

namespace WEBMVC.Controllers
{
    public class ClienteController : Controller
    {

        static MapperConfiguration config = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<Cliente, ClienteModel>().ReverseMap();
            //cfg.CreateMap<ClienteModel, Cliente>().;

        });

        private readonly YanbalDbContext yanbalDbContext;
        public ClienteController(YanbalDbContext context)
        {
            yanbalDbContext = context;
        }
        
        // GET: ClienteController
        
        public ActionResult Index()
        {
            return View(yanbalDbContext.Clientes.ProjectTo<ClienteModel>(config).ToList());            
        }

        // GET: ClienteController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ClienteController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ClienteController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public async Task<ActionResult> Create([Bind("Nombres,Apellidos,Correo,FechaNacimiento,Direccion")]ClienteModel clienteM)
        {
            try
            {
                if (ModelState.IsValid)
                {                    
                    var clientes = yanbalDbContext.Clientes.ToList();

                    ErrorValidation errorModel = new ErrorValidation();
                    errorModel.Correo = clienteM.Correo;

                    if (clientes.Where(c=> c.Correo == clienteM.Correo).Any())
                    {
                        return View("ErrorValidation", errorModel);
                    }

                    Mapper mapper = (Mapper)config.CreateMapper();

                    Cliente cliente = mapper.Map<Cliente>(clienteM);  
                    cliente.FechaRegistro = DateTime.UtcNow;                    

                    yanbalDbContext.Add(cliente);
                    await yanbalDbContext.SaveChangesAsync();

                }
                                
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {                
                return View("Error", new ErrorViewModel { MessageException = ex.Message, InnerException = ex.InnerException.Message });
            }
        }

        // GET: ClienteController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ClienteController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ClienteController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ClienteController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
