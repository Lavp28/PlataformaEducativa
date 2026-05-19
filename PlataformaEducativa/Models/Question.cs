/*
 * Created by SharpDevelop.
 * User: R0wy-_-!
 * Date: 17/5/2026
 * Time: 12:40 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

using System.Collections.Generic;

namespace PlataformaEducativa.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public int ModuleID { get; set; }
        public string Text_Es { get; set; }
        public string Text_En { get; set; }
        public string ImagePath { get; set; }
        public List<Option> Options { get; set; }

        public Question()
        {
            Options = new List<Option>();
        }
    }

    public class Option
    {
        public int OptionID { get; set; }
        public int QuestionID { get; set; }
        public string Text_Es { get; set; }
        public string Text_En { get; set; }
        public bool IsCorrect { get; set; }
    }
}
