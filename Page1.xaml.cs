using ImagemOcorrencia.Models;
using System;
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
using static System.Net.Mime.MediaTypeNames;

namespace ImagemOcorrencia
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1(List<Comment_Ocorrencia> Comentario)
        {
            // ***********************DEFINE O NUMERO DE LINHAS QUE VAMOS TER COM TODOS COMENTÁRIOS*******

            InitializeComponent();
            var numeroComentarios = Comentario.Count;
            var numeroLinhas = Comentario.Count * 3;
            var b = 0;                 


            for (int contador = 0; contador < numeroLinhas; contador++)
            {
                b = b + 1;

                RowDefinition rowDef1 = new RowDefinition();
                ComentarioGrid.RowDefinitions.Add(rowDef1);
            }

            // ***********************DEFINE OS COMENTÁRIOS DAS OCORRÊNCIAS*******************************

            var row = 0;

            foreach (var item in Comentario)
            {
                //----------------------------------------------------Disciplina--------------------------
                TextBlock disciplina = new TextBlock()
                {
                    Text = item.Disciplina
                };
                ComentarioGrid.Children.Add(disciplina);
                Grid.SetColumn(disciplina, 0);
                Grid.SetRow(disciplina, row * 3);
                //----------------------------------------------------Data--------------------------------
                TextBlock data = new TextBlock()
                {
                    Text = item.Data
                };
                ComentarioGrid.Children.Add(data);
                data.HorizontalAlignment = HorizontalAlignment.Right;
                Grid.SetColumn(data, 2);
                Grid.SetRow(data, row * 3);
                //----------------------------------------------------Comentário--------------------------
                TextBlock comentario = new TextBlock()
                {
                    Text = item.Comentario
                };

                ComentarioGrid.Children.Add(comentario);
                comentario.TextWrapping = TextWrapping.Wrap;
                Grid.SetColumnSpan(comentario, 3);
                Grid.SetRow(comentario, row * 3 + 1);

                //----------------------------------------------------Linha em branco--------------------------
                TextBlock linhaBranco = new TextBlock()
                {
                    Text = item.LinhaBranco
                };
                ComentarioGrid.Children.Add(linhaBranco);
                Grid.SetColumnSpan(linhaBranco, 3);
                Grid.SetRow(linhaBranco, row * 3 + 2);

                row = row + 1;

            }         

        }

    }

}
