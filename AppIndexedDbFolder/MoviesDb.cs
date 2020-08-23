using Blazor.IndexedDB.Framework;
using IndexedDBApp.Models;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IndexedDBApp.AppIndexedDbFolder
{
    public class MoviesDb : IndexedDb
    {
        public MoviesDb(IJSRuntime jSRuntime, string name, int version) : base(jSRuntime, name, version) { }

    // These are like tables. Declare as many of them as you want.    
        public IndexedSet<MovieModel> Movies { get; set; }       
    }


}
