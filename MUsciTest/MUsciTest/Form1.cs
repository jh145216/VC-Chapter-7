﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUsciTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlaySong_Click(object sender, EventArgs e)
        {
           
        }

        private void btnsimpleSound_Click(object sender, EventArgs e)
        {

        }
    }
}


    private void playSimpleSound()
    { 
        SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");  
        simpleSound.Play();  
    }  
}

