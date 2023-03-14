﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_NegyedikHet
{
    public partial class Form1 : Form
    {
        List<Flat> _flats;
        RealEstateEntities context = new RealEstateEntities();

        public Form1()
        {
            InitializeComponent();
            LoadData();
        }

        void LoadData()
        {
            _flats = context.Flats.ToList();

        }
    }
}