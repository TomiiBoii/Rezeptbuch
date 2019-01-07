using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
namespace Rezeptbuch
{
    #region Rezepte
    public class Rezepte
    {
        #region Member Variables
        protected int _ID;
        protected string _namerecipe;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _ingredient;
        protected string _preparation;
        protected string _cathegory;
        protected string _cathegory;
        protected string _cathegory;
        protected string _difficulty;
        protected string _time;
        protected string _amount;
        protected string _source;
        #endregion
        #region Constructors
        public Rezepte() { }
        public Rezepte(string namerecipe, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string ingredient, string preparation, string cathegory, string cathegory, string cathegory, string difficulty, string time, string amount, string source)
        {
            this._namerecipe=namerecipe;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._ingredient=ingredient;
            this._preparation=preparation;
            this._cathegory=cathegory;
            this._cathegory=cathegory;
            this._cathegory=cathegory;
            this._difficulty=difficulty;
            this._time=time;
            this._amount=amount;
            this._source=source;
        }
        #endregion
        #region Public Properties
        public virtual int ID
        {
            get {return _ID;}
            set {_ID=value;}
        }
        public virtual string Namerecipe
        {
            get {return _namerecipe;}
            set {_namerecipe=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Ingredient
        {
            get {return _ingredient;}
            set {_ingredient=value;}
        }
        public virtual string Preparation
        {
            get {return _preparation;}
            set {_preparation=value;}
        }
        public virtual string Cathegory
        {
            get {return _cathegory;}
            set {_cathegory=value;}
        }
        public virtual string Cathegory
        {
            get {return _cathegory;}
            set {_cathegory=value;}
        }
        public virtual string Cathegory
        {
            get {return _cathegory;}
            set {_cathegory=value;}
        }
        public virtual string Difficulty
        {
            get {return _difficulty;}
            set {_difficulty=value;}
        }
        public virtual string Time
        {
            get {return _time;}
            set {_time=value;}
        }
        public virtual string Amount
        {
            get {return _amount;}
            set {_amount=value;}
        }
        public virtual string Source
        {
            get {return _source;}
            set {_source=value;}
        }
        #endregion
    }
    #endregion
}
