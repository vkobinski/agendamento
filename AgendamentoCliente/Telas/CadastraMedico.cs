using AgendamentoCliente.Models;

namespace AgendamentoCliente.Telas
{
    public partial class CadastraMedico : Form
    {
        private Point startPoint;
        private Rectangle selectionRectangle;
        private bool isMovingSelection = false;
        private Bitmap croppedImage;
        private bool dragging = false;
        private Point dragStartPoint;
        private PointF imageStartPoint;
        private PointF imageLocation = new PointF(0, 0);
        private float zoomFactor = 1.0F;
        private Image imagemMedico;

        public CadastraMedico()
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, fotoMedico.Width - 3, fotoMedico.Height - 3);
            Region rg = new Region(gp);
            fotoMedico.Region = rg;

            fotoMedico.MouseWheel += new MouseEventHandler(fotoMedico_MouseWheel);
            this.AutoScroll = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
            Close();
        }


        private async Task enviarForm()
        {
            var nome = txbNomeMedico.Text;
            var email = txbEmail.Text;
            var senha = txbSenha.Text;

            HttpClient httpClient = new HttpClient();

            MultipartFormDataContent formData = new MultipartFormDataContent();

            try
            {

                if (nome.Length <= 0 || email.Length <= 0 || senha.Length <= 0)
                {
                    throw new Exception();
                }

                Bitmap bmp = GetModifiedImage();

                using (var ms = new MemoryStream())
                {
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    ms.Position = 0;
                    StreamContent fileContent = new StreamContent(ms);
                    formData.Add(fileContent, "foto", fotoMedico.Name);

                    formData.Add(new StringContent(nome), "nomeCompleto");
                    formData.Add(new StringContent(email), "email");
                    formData.Add(new StringContent(senha), "senha");

                    HttpResponseMessage response = await httpClient.PostAsync(Utils.GetIp("/api/v1/usuario/form-medico"), formData);
                    if (!response.IsSuccessStatusCode)
                    {
                        btnCadastrar.Enabled = true;
                        MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
                    }
                    else
                    {
                        MenuSingleton.Instance.MenuVisible();
                        Close();
                    }


                }
            }
            catch (Exception ex)
            {
                btnCadastrar.Enabled = true;
                MessageBox.Show("Não foi possível cadastrar, verifique se há algum campo vazio");
            }
        }

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Enabled = false;
            await enviarForm();
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog open = new OpenFileDialog();
                open.Filter = string.Empty;
                if (open.ShowDialog() == DialogResult.OK)
                {
                    fotoMedico.Image = new Bitmap(open.FileName);
                    this.imagemMedico = fotoMedico.Image;
                    fotoMedico.ImageLocation = open.FileName;

                    fotoMedico.Invalidate();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir a imagem");
            }
        }
        private void CadastraMedico_FormClosing(object sender, FormClosingEventArgs e)
        {
            MenuSingleton.Instance.MenuVisible();
        }

        private void fotoMedico_MouseDown(object sender, MouseEventArgs e)
        {

            dragging = true;
            dragStartPoint = e.Location;
            imageStartPoint = imageLocation;

        }

        private void fotoMedico_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void fotoMedico_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                imageLocation = new PointF(
                    imageStartPoint.X + (e.X - dragStartPoint.X),
                    imageStartPoint.Y + (e.Y - dragStartPoint.Y));

                fotoMedico.Invalidate();
            }
        }

        private void fotoMedico_MouseWheel(object sender, MouseEventArgs e)
        {
            const float minZoomFactor = 0.1f;  // Minimum zoom factor

            if (e.Delta > 0)
            {
                zoomFactor += 0.2f;
            }
            else if (e.Delta < 0)
            {
                if (zoomFactor > minZoomFactor + 0.2f)  // Ensure you don't zoom out beyond the minimum zoom factor
                {
                    zoomFactor -= 0.2f;
                }
            }

            // Compute the new width and height after zooming
            float newWidth = imagemMedico.Width * zoomFactor;
            float newHeight = imagemMedico.Height * zoomFactor;

            // Compute the difference between the picture box and the new image size
            float widthDifference = fotoMedico.Width - newWidth;
            float heightDifference = fotoMedico.Height - newHeight;

            // Adjust the image location to center the image
            imageLocation.X = widthDifference / 2;
            imageLocation.Y = heightDifference / 2;

            fotoMedico.Invalidate();
        }

        private void CadastraMedico_Paint(object sender, PaintEventArgs e)
        {
            if (fotoMedico.Image != null)
            {
                e.Graphics.Clear(BackColor);
                e.Graphics.DrawImage(imagemMedico, new RectangleF(imageLocation.X, imageLocation.Y, imagemMedico.Width * zoomFactor, imagemMedico.Height * zoomFactor));
            }
        }

        private Bitmap GetModifiedImage()
        {
            Bitmap bmp = new Bitmap(fotoMedico.Width, fotoMedico.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                if (imagemMedico != null) g.DrawImage(imagemMedico, new RectangleF(imageLocation.X, imageLocation.Y, imagemMedico.Width * zoomFactor, imagemMedico.Height * zoomFactor));
                else
                {
                    throw new Exception();
                }
            }

            return bmp;
        }

        private void CadastraMedico_Load(object sender, EventArgs e)
        {

        }

        private void txbNomeMedico_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
