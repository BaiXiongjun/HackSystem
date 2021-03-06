﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StartUpTemplate;

namespace AnimationStartUp
{
    public class GirlStartUpClass : StartUpTemplateClass
    {
        public GirlStartUpClass()
        {
            Name = "女孩";
            Description = "女孩启动画面 - Leon";
            Preview = StartUpResource.GirlPreview;
        }

        public override string FileName => System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.ScopeName;

        protected override Form CreateStartUpForm()
        {
            return new CommonAnimationForm(StartUpResource.Girl, Color.FromArgb(255, 217, 225, 213)) { ParentStartUp = this, ForeColor = Color.DeepPink };
        }
    }
}
