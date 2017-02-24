﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfLabs.ExpertPanel.Models;

namespace WpfLabs.ExpertPanel
{
    /// <summary>
    /// ExpertPanel.xaml 的交互逻辑
    /// </summary>
    public partial class ExpertPanel : UserControl
    {
        public static readonly DependencyProperty ItemSourcesProperty = DependencyProperty.Register(
            "ItemsSource", typeof(List<ExpertModel>), typeof(ExpertPanel),
            new PropertyMetadata(default(List<ExpertModel>)));

        /// <summary>
        /// 专家数据源数据源
        /// </summary>
        public List<ExpertModel> ItemsSource
        {
            get { return (List<ExpertModel>) GetValue(ItemSourcesProperty); }
            set { SetValue(ItemSourcesProperty, value); }
        }

        public ExpertPanel()
        {
            InitializeComponent();
        }
    }
}