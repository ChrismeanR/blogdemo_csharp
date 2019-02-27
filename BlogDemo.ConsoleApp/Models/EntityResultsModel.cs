using System;
using System.Collections.Generic;

namespace BlogDemo.ConsoleApp.Models
{
    public class EntityResultsModel<T> : EntityModel where T : EntityModel
    {
        public string previous
        {
            get;
            set;
        }

        public string next
        {
            get;
            set;
        }

        public string previousPageNo
        {
            get;
            set;
        }

        public string nextPageNo
        {
            get;
            set;
        }

        public Int64 count
        {
            get;
            set;
        }

        public List<T> results
        {
            get;
            set;
        }
    }
}