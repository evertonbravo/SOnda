using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sonda
{
    public partial class Planalto : System.Web.UI.Page
    {
        #region Eventos
        protected override void OnInit(EventArgs e)
        {
            int cordx = Convert.ToInt32(Session["cordx"]);
            int cordy = Convert.ToInt32(Session["cordy"]);
            for (int y = cordx; y >= 0; y--)
            {
                //cria coluna
                var v = 0;
                for (int x = 0; x <= cordx; x++)
                {
                    // Create dynamic controls here.
                    // Use "using System.Web.UI.WebControls;"
                    Image imagem = new Image();
                    imagem.ID = "x" + x.ToString() + "y" + y.ToString();
                    imagem.ImageUrl = "~/img/fundo01.png";
                    imagem.Width = 100;
                    PainelPlanalto.Controls.Add(imagem);
                    v = 1;
                    //cria linha

                }
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("<br/>");
                Label lbl = new Label();
                lbl.ID = y.ToString();
                lbl.Text = sb.ToString();
                PainelPlanalto.Controls.Add(lbl);
            }
            base.OnInit(e);

            // ... seu código de criação dos controles dinâmicos aqui
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnNovaSonda_Click(object sender, ImageClickEventArgs e)
        {


            if (CordX.Text != String.Empty && CordY.Text != String.Empty)
            {
                if (Helper.IsNumeric(CordX.Text) && Helper.IsNumeric(CordY.Text))
                {
                    int cordx = Convert.ToInt32(CordX.Text);
                    int cordy = Convert.ToInt32(CordY.Text);
                    if (!UltrapassaLimitex(cordx) && !UltrapassaLimitey(cordy))
                    {
                        if (sonda2.Visible == true)
                        {
                            //Captura ponto de entrada
                            Image img3 = (Image)PainelPlanalto.FindControl("x" + CordX.Text + "y" + CordY.Text);
                            if (img3 != null)
                            {
                                //Verifica se o ponto esta vazio
                                if (img3.ImageUrl == "~/img/fundo01.png")
                                {
                                    sonda3.Visible = true;
                                    Sonda3x.Value = CordX.Text;
                                    Sonda3y.Value = CordY.Text;
                                    Sonda3s.Value = DDSentido.SelectedValue;

                                    img3.ImageUrl = "~/img/3" + Sonda3s.Value + ".png";

                                    NovaSonda.Visible = false;
                                }
                            }
                        }
                        else if (sonda1.Visible == true)
                        {  //Captura ponto de entrada
                            Image img2 = (Image)PainelPlanalto.FindControl("x" + CordX.Text + "y" + CordY.Text);
                            if (img2 != null)
                            {
                                //Verifica se o ponto esta vazio
                                if (img2.ImageUrl == "~/img/fundo01.png")
                                {
                                    sonda2.Visible = true;
                                    Sonda2x.Value = CordX.Text;
                                    Sonda2y.Value = CordY.Text;
                                    Sonda2s.Value = DDSentido.SelectedValue;
                                    img2.ImageUrl = "~/img/2" + Sonda2s.Value + ".png";
                                }
                            }

                        }
                        else
                        {
                            PainelControles.Visible = true;
                            sonda1.Visible = true;
                            Sonda1x.Value = CordX.Text;
                            Sonda1y.Value = CordY.Text;
                            Sonda1s.Value = DDSentido.SelectedValue;
                            Image img1 = (Image)PainelPlanalto.FindControl("x" + Sonda1x.Value + "y" + Sonda1y.Value);
                            if (img1 != null)
                            {
                                img1.ImageUrl = "~/img/1" + Sonda1s.Value + ".png";
                            }
                        }
                        CordX.Text = "";
                        CordY.Text = "";

                    }
                }
            }
        }      

        protected void btn1esquerda_Click(object sender, ImageClickEventArgs e)
        {
            Sonda1s.Value = MovimentaEsquerda(Sonda1s.Value); 
            Image img1 = (Image)PainelPlanalto.FindControl("x" + Sonda1x.Value + "y" + Sonda1y.Value);
            if (img1 != null)
            {
                img1.ImageUrl = "~/img/1" + Sonda1s.Value + ".png";
            }
        }

        protected void btn1direita_Click(object sender, ImageClickEventArgs e)
        {
            Sonda1s.Value = MovimentaDireita(Sonda1s.Value);              
            Image img1 = (Image)PainelPlanalto.FindControl("x" + Sonda1x.Value + "y" + Sonda1y.Value);
            if (img1 != null)
            {
                img1.ImageUrl = "~/img/1" + Sonda1s.Value + ".png";
            }
        }

        protected void btn2esquerda_Click(object sender, ImageClickEventArgs e)
        {            
            Sonda2s.Value = MovimentaEsquerda(Sonda2s.Value);     
            Image img2 = (Image)PainelPlanalto.FindControl("x" + Sonda2x.Value + "y" + Sonda2y.Value);
            if (img2 != null)
            {
                img2.ImageUrl = "~/img/2" + Sonda2s.Value + ".png";
            }
        }

        protected void btn2direita_Click(object sender, ImageClickEventArgs e)
        {
            Sonda2s.Value = MovimentaDireita(Sonda2s.Value);            
            Image img2 = (Image)PainelPlanalto.FindControl("x" + Sonda2x.Value + "y" + Sonda2y.Value);
            if (img2 != null)
            {
                img2.ImageUrl = "~/img/2" + Sonda2s.Value + ".png";
            }
        }

        protected void btn3esquerda_Click(object sender, ImageClickEventArgs e)
        {
            Sonda3s.Value = MovimentaEsquerda(Sonda3s.Value);               
            Image img3 = (Image)PainelPlanalto.FindControl("x" + Sonda3x.Value + "y" + Sonda3y.Value);
            if (img3 != null)
            {
                img3.ImageUrl = "~/img/3" + Sonda3s.Value + ".png";
            }
        }

        protected void ImageButton9_Click(object sender, ImageClickEventArgs e)
        {
            Sonda3s.Value = MovimentaDireita(Sonda3s.Value);      
            Image img3 = (Image)PainelPlanalto.FindControl("x" + Sonda3x.Value + "y" + Sonda3y.Value);
            if (img3 != null)
            {
                img3.ImageUrl = "~/img/3" + Sonda3s.Value + ".png";
            }
        }

        protected void btn1Seguir_Click(object sender, ImageClickEventArgs e)
        {
            int valorx = Convert.ToInt32(Sonda1x.Value);
            int valory = Convert.ToInt32(Sonda1y.Value);
            switch (Sonda1s.Value)
            {
                case "n":
                    valory = valory +1;
                    break;
                case "e":
                    valorx = valorx + 1;
                    break;
                case "s":
                    valory = valory-1;
                    break;
                case "w":
                    valorx = valorx -1;
                    break;

            }
            if (!UltrapassaLimitex(valorx) && !UltrapassaLimitey(valory))
            {
                //verifica o proximo pornto
                Image img1 = (Image)PainelPlanalto.FindControl("x" + valorx + "y" + valory);
                if (img1 != null)
                {
                    //Verifica se o ponto esta vazio
                    if (img1.ImageUrl == "~/img/fundo01.png")
                    {
                        //ponto antigo recebe imagem padrão
                        Image img2 = (Image)PainelPlanalto.FindControl("x" + Sonda1x.Value + "y" + Sonda1y.Value);
                        if (img2 != null)
                        {
                            img2.ImageUrl = "~/img/fundo01.png";
                        }
                        Sonda1x.Value = valorx.ToString();
                        Sonda1y.Value = valory.ToString();
                        img1.ImageUrl = "~/img/1" + Sonda1s.Value + ".png";
                    }
                }
            }
            
        }

        protected void btn2seguir_Click(object sender, ImageClickEventArgs e)
        {
            int valorx = Convert.ToInt32(Sonda2x.Value);
            int valory = Convert.ToInt32(Sonda2y.Value);
            switch (Sonda2s.Value)
            {
                case "n":
                    valory = valory + 1;
                    break;
                case "e":
                    valorx = valorx + 1;
                    break;
                case "s":
                    valory = valory - 1;
                    break;
                case "w":
                    valorx = valorx - 1;
                    break;

            }
            if (!UltrapassaLimitex(valorx) && !UltrapassaLimitey(valory))
            {
                //verifica o proximo pornto
                Image img1 = (Image)PainelPlanalto.FindControl("x" + valorx + "y" + valory);
                if (img1 != null)
                {
                    //Verifica se o ponto esta vazio
                    if (img1.ImageUrl == "~/img/fundo01.png")
                    {
                        //ponto antigo recebe imagem padrão
                        Image img2 = (Image)PainelPlanalto.FindControl("x" + Sonda2x.Value + "y" + Sonda2y.Value);
                        if (img2 != null)
                        {
                            img2.ImageUrl = "~/img/fundo01.png";
                        }
                        Sonda2x.Value = valorx.ToString();
                        Sonda2y.Value = valory.ToString();
                        img1.ImageUrl = "~/img/2" + Sonda2s.Value + ".png";
                    }
                }
            }
        }

        protected void btn3seguir_Click(object sender, ImageClickEventArgs e)
        {
            int valorx = Convert.ToInt32(Sonda3x.Value);
            int valory = Convert.ToInt32(Sonda3y.Value);
            switch (Sonda3s.Value)
            {
                case "n":
                    valory = valory + 1;
                    break;
                case "e":
                    valorx = valorx + 1;
                    break;
                case "s":
                    valory = valory - 1;
                    break;
                case "w":
                    valorx = valorx - 1;
                    break;

            }
            if (!UltrapassaLimitex(valorx) && !UltrapassaLimitey(valory))
            {
                //verifica o proximo pornto
                Image img1 = (Image)PainelPlanalto.FindControl("x" + valorx + "y" + valory);
                if (img1 != null)
                {
                    //Verifica se o ponto esta vazio
                    if (img1.ImageUrl == "~/img/fundo01.png")
                    {
                        //ponto antigo recebe imagem padrão
                        Image img2 = (Image)PainelPlanalto.FindControl("x" + Sonda3x.Value + "y" + Sonda3y.Value);
                        if (img2 != null)
                        {
                            img2.ImageUrl = "~/img/fundo01.png";
                        }
                        Sonda3x.Value = valorx.ToString();
                        Sonda3y.Value = valory.ToString();
                        img1.ImageUrl = "~/img/3" + Sonda3s.Value + ".png";
                    }
                }
            }
        }

        protected void btnCapturar1_Click(object sender, ImageClickEventArgs e)
        {
            CapturarImagem();
        }
        

        protected void btnCapturar2_Click(object sender, ImageClickEventArgs e)
        {
            CapturarImagem();
        }

        protected void btnCapturar3_Click(object sender, ImageClickEventArgs e)
        {
            CapturarImagem();
        }

        protected void btnCapturar4_Click(object sender, ImageClickEventArgs e)
        {
            PainelControles.Visible = true;
            PainelPlanalto.Visible = true;
            PainelCaptura.Visible = false;
            if (sonda3.Visible == false)
            {
                NovaSonda.Visible = true;
            }
        }
        #endregion

        #region Métodos
        //Método que Captura a imagem 
        public void CapturarImagem()
        {
            PainelControles.Visible = false;
            PainelPlanalto.Visible = false;
            PainelCaptura.Visible = true;
            if (sonda3.Visible == false)
            {
                NovaSonda.Visible = false;
            }
            int valorimagem = Convert.ToInt32(HFiimagem.Value);
            if (valorimagem == 0 || valorimagem == 8)
            {
                valorimagem = 1;
            }
            else
            {
                valorimagem = valorimagem + 1;
            }
            ImgCapturada.ImageUrl = "~/img/marte/" + valorimagem + ".jpg";
            HFiimagem.Value = valorimagem.ToString();
        }
        //Verifica Limite de x
        public bool UltrapassaLimitex(int valor)
        {
            int limitex = Convert.ToInt32(Session["cordx"]);
            bool ultrapassa = (valor > limitex && valor > 0) ? true : false;
            return ultrapassa;
        }
        //Verifica Limite de y
        protected bool UltrapassaLimitey(int valor)
        {
            int limitey = Convert.ToInt32(Session["cordy"]);
            bool ultrapassa = (valor > limitey && valor > 0) ? true : false;
            return ultrapassa;

        }

        public string MovimentaDireita(string sentido)
        {
            switch (sentido)
            {
                case "n":
                    sentido = "e";
                    break;
                case "e":
                    sentido = "s";
                    break;
                case "s":
                    sentido = "w";
                    break;
                case "w":
                    sentido = "n";
                    break;
            }
            return sentido;
        }

        public string MovimentaEsquerda(string sentido)
        {
            switch (sentido)
            {
                case "n":
                    sentido = "w";
                    break;
                case "w":
                    sentido = "s";
                    break;
                case "s":
                    sentido = "e";
                    break;
                case "e":
                    sentido = "n";
                    break;
            }
            return sentido;
        }
        

        #endregion
    }


}