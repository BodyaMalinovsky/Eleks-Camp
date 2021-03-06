﻿using System;

namespace EleksCamp_CA.Domain
{
    public class Book : IComparable
    {
        private static int _counter = 0;

        private readonly int _id;
        public int Id => this._id; 

        private readonly string _name;
        public string Name => this._name;

        private readonly int _pages;
        public int Pages => this._pages;

        private readonly string _description;
        public string Description => this._description;
         
        public Book(string name, int pages, string description = null)
        {
            this._id = _counter++;
            this._name = name;
            this._pages = pages;
            this._description = description;
        }

        public override string ToString()
        {
            return $"Book name: '{_name}', Pages={_pages}. Description: {_description}.";
        }

        public int CompareTo(object obj)
        {
            if (obj == null) return 1;

            Book otherBook = obj as Book;

            if (otherBook == null)
            {
                throw new ArgumentException("Object is not a Book");
            }

            return this._pages > otherBook.Pages
                ? 1
                : this._pages == otherBook.Pages
                    ? 0
                    : -1;
        }
    }
}