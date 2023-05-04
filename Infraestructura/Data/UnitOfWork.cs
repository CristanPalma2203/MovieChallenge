﻿using System;
using Dominio.Services;
using Microsoft.EntityFrameworkCore;

namespace Infraestructura.Data
{
    public sealed class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly MovieContext _context;
        private bool _disposed = false;

        public UnitOfWork(MovieContext context)
        {
            _context = context;
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public DbContext GetContext()
        {
            return _context;
        }
    }
}
