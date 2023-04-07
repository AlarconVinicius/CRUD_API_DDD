using Microsoft.EntityFrameworkCore;
using Microsoft.Win32.SafeHandles;
using ProjCrudApi.Dominio.Interfaces.IGenerica;
using ProjCrudApi.Infraestrutura.Configuracao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjCrudApi.Infraestrutura.Repositorios.Generico
{
    public class RepositorioGenerico<T> : IGenerica<T>, IDisposable where T : class
    {
        protected readonly ContextoBase _context;

        public RepositorioGenerico(ContextoBase context)
        {
            _context = context;
        }
        public async Task Add(T objeto)
        {
            await _context.Set<T>().AddAsync(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(T objeto)
        {
            _context.Set<T>().Remove(objeto);
            await _context.SaveChangesAsync();
        }

        public async Task<T> GetEntityById(Guid Id)
        {
            return await _context.Set<T>().FindAsync(Id);
        }

        public async Task<List<T>> List()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Update(T objeto)
        {
            _context.Set<T>().Update(objeto);
            await _context.SaveChangesAsync();
        }

        #region Disposed https://docs.microsoft.com/pt-br/dotnet/standard/garbage-collection/implementing-dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);



        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion

    }
}
