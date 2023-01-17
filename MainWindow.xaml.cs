using ImagemOcorrencia.Models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImagemOcorrencia
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Comment_Ocorrencia> listaComentario { get; set; }


        public MainWindow()
        {
            listaComentario = new List<Comment_Ocorrencia>();
            InitializeComponent();
            this.status.ItemsSource = new List<string> { "Atendida", "Pendente",  };
            this.disciplina.ItemsSource = new List<string> { "Arquitetura", "Estrutura", "Paisagismo" };
            this.prioridade.ItemsSource = new List<string> { "Alta", "Normal" };
            this.faseProjeto.ItemsSource = new List<string> { "Fase 02 - PE - Torre", "Fase 03 - PE - Embasamento", "Fase 04 - LO - Embasamento" };
            this.responsavel.ItemsSource = new List<string> { "arquitetura@gmail.com", "estrutura@gmail.com", "paisagismo@gmail.com" };
            FormatDT();

           void FormatDT()
            {
                var dt=DateTime.Now;
                DatApontamento.Text = dt.ToString(("dd/MM/yyyy "));
            }


        }

        private void Main_Navigated(object sender, NavigationEventArgs e)
        {

        }

        private void BtnClickComentarios(object sender, RoutedEventArgs e)
        {
            for (int contador = 0; contador < 2; contador++)
            {
                var exemploComentario = new Comment_Ocorrencia()
                {
                    Disciplina = "Arquitetura",
                    Data = DateTime.Now.ToString("d"),
                    Comentario = "Teste do comentario",
                    LinhaBranco = ""
                };
                listaComentario.Add(exemploComentario);
            }

           

            //var exemploComentario1 = new Comment_Ocorrencia()
            //{
            //    Disciplina = "Coordenação",
            //    Data = DateTime.Now.ToString("d"),
            //    Comentario = "Esse é um outro teste de coordenação dos comentarios maior para ver o que acontece",
            //    LinhaBranco = ""

            //};

            //listaComentario.Add(exemploComentario1);

            var lista = new List<string> { "Paulo", "Andre", "Tito" };

            Main.Content = new Page1(listaComentario);

        }

        private void BtnOnclickAnexos(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page2();
        }

        private void BtnOnclickHistorico(object sender, RoutedEventArgs e)
        {
            Main.Content = new Page3();
        }
    }
}
