using Produto.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace Produto
{
    public partial class produto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Products> listaProducts = new List<Products>();
                Session["produtos"] = listaProducts;
            }
 
        }

        protected void btnInserir_Click(object sender, EventArgs e)
        {
            List<Products> listaProducts = (List<Products>)Session["produtos"];
            Products products = new Products();
            products.Id = Convert.ToInt32(txtId.Text);
            products.Nome = txtNome.Text;
            products.Valor = Convert.ToDouble(txtValor.Text);
            listaProducts.Add(products);
            grdProdutos.DataSource = listaProducts;
            grdProdutos.DataBind();
        }

        protected void btnPesquisar_Click(object sender, EventArgs e)
        {
            List<Products> listaProducts = (List<Products>)Session["produtos"];
            foreach(Products item in listaProducts)
            {
                if(item.Id == Convert.ToInt32(txtId.Text))
                {
                    txtNome.Text = item.Nome;
                    txtValor.Text = item.Valor.ToString();
                }
            }
        }

        protected void btnAlterar_Click(object sender, EventArgs e)
        {
            List<Products> listaProducts = (List<Products>)Session["produtos"];
            foreach (Products item in listaProducts)
            {
                if (item.Id == Convert.ToInt32(txtId.Text))
                {
                    item.Nome = txtNome.Text;
                    item.Valor = Convert.ToDouble(txtValor.Text);
                }
            }

            grdProdutos.DataSource = listaProducts;
            grdProdutos.DataBind();
        }

        protected void btnExcluir_Click(object sender, EventArgs e)
        {
            List<Products> listaProducts = (List<Products>)Session["produtos"];
            Products delProduct = null;
            foreach (Products item in listaProducts)
            {
                if (item.Id == Convert.ToInt32(txtId.Text))
                {
                    delProduct = item;
                }
            }

            listaProducts.Remove(delProduct);

            grdProdutos.DataSource = listaProducts;
            grdProdutos.DataBind();
        }
    }
}