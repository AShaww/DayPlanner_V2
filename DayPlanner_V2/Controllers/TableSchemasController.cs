using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DayPlanner_V2.Data;
using DayPlanner_V2.Models;

namespace DayPlanner_V2.Controllers
{
    public class TableSchemasController : Controller
    {
        private readonly DayPlanner_V2Context _context;

        public TableSchemasController(DayPlanner_V2Context context)
        {
            _context = context;
        }

        // GET: TableSchemas
        public async Task<IActionResult> Index()
        {
              return _context.TableSchema != null ? 
                          View(await _context.TableSchema.ToListAsync()) :
                          Problem("Entity set 'DayPlanner_V2Context.TableSchema'  is null.");
        }

        // GET: TableSchemas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.TableSchema == null)
            {
                return NotFound();
            }

            var tableSchema = await _context.TableSchema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSchema == null)
            {
                return NotFound();
            }

            return View(tableSchema);
        }

        // GET: TableSchemas/Create
        public ActionResult Create()
        {
            return View(new TableSchema { CreatedAt = DateTime.Now });
        }

        // POST: TableSchemas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CreatedAt,TopPriorities1,TopPriorities2,TopPriorities3,BrainDump,FiveAM00,FiveAM30,SixAM00,SixAM30,SevenAM00,SevenAM30,EightAM00,EightAM30,NineAM00,NineAM30,TenAM00,TenAM30,ElevenAM00,ElevenAM30,TwelveAM00,TwelveAM30,OnePM00,OnePM30,TwoPM00,TwoPM30,ThreePM00,ThreePM30,FourPM00,FourPM30,FivePM00,FivePM30,SixPM00,SixPM30,SevenPM00,SevenPM30,EightPM00,EightPM30,NinePM00,NinePM30,TenPM00,TenPM30,ElevenPM00,ElevenPM30")] TableSchema tableSchema)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tableSchema);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tableSchema);
        }

        // GET: TableSchemas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.TableSchema == null)
            {
                return NotFound();
            }

            var tableSchema = await _context.TableSchema.FindAsync(id);
            if (tableSchema == null)
            {
                return NotFound();
            }
            return View(tableSchema);
        }

        // POST: TableSchemas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CreatedAt,TopPriorities1,TopPriorities2,TopPriorities3,BrainDump,FiveAM00,FiveAM30,SixAM00,SixAM30,SevenAM00,SevenAM30,EightAM00,EightAM30,NineAM00,NineAM30,TenAM00,TenAM30,ElevenAM00,ElevenAM30,TwelveAM00,TwelveAM30,OnePM00,OnePM30,TwoPM00,TwoPM30,ThreePM00,ThreePM30,FourPM00,FourPM30,FivePM00,FivePM30,SixPM00,SixPM30,SevenPM00,SevenPM30,EightPM00,EightPM30,NinePM00,NinePM30,TenPM00,TenPM30,ElevenPM00,ElevenPM30")] TableSchema tableSchema)
        {
            if (id != tableSchema.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tableSchema);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TableSchemaExists(tableSchema.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tableSchema);
        }

        // GET: TableSchemas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.TableSchema == null)
            {
                return NotFound();
            }

            var tableSchema = await _context.TableSchema
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tableSchema == null)
            {
                return NotFound();
            }

            return View(tableSchema);
        }

        // POST: TableSchemas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.TableSchema == null)
            {
                return Problem("Entity set 'DayPlanner_V2Context.TableSchema'  is null.");
            }
            var tableSchema = await _context.TableSchema.FindAsync(id);
            if (tableSchema != null)
            {
                _context.TableSchema.Remove(tableSchema);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TableSchemaExists(int id)
        {
          return (_context.TableSchema?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
