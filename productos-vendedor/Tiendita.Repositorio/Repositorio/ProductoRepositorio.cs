﻿using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using reglasdenegocio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tiendita.Entity.Interfaces.Repositorios;
using Tiendita.ReglasdeNegocio.ExcepcionesPersonales;
using Tiendita.Repositorio.Contexto;

namespace Tiendita.Repositorio.Repositorio
{
    public class ProductoRepositorio : IProductosRepository
    {
        readonly TienditaContext _context;

        public ProductoRepositorio(TienditaContext context)
        {
            _context = context;
        }

        public async Task Create(Producto producto)
        {
            try
            {
                await _context.AddAsync(producto);
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task Delete(int productoId)
        {
            try
            {
                var result = await _context.productos.FirstOrDefaultAsync(a => a.Id == productoId && a.IsDeleted == false);
                if (result != null)
                {
                    result.IsDeleted = true;
                }
                else
                {
                    throw new DBMySqlException(404, "El registro no fue encontrado");
                }
            }
            catch (MySqlException ex)
            {
                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<List<Producto>> obtenerTodoslosProductos()
        {
            try
            {
                List<Producto> result = new List<Producto>();
                result = await _context.productos.Where(a => a.IsDeleted == false).ToListAsync();
                return result;
            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task<Producto> obtenerporId(int id)
        {
            try
            {
                Producto result = new Producto();
                result = await _context.productos.FirstOrDefaultAsync(a => a.Id == id && a.IsDeleted == false);
                return result;

            }
            catch (MySqlException ex)
            {

                throw new DBMySqlException(ex.Number, ex.Message);
            }
        }

        public async Task GuardarCambios()
        {
            await _context.SaveChangesAsync();
        }

        public Task Update(Producto producto)
        {
            throw new NotImplementedException();
        }
    }
}
