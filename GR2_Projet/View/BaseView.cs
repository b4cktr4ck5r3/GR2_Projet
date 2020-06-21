using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GR2_Projet.View
{
    /// <summary>
    /// Classe BaseView, permet à tout les contrôles utilisateurs de disposés des méthodes décrites ci-dessous ainsi que des méthodes de la classe UserControl.
    /// </summary>
    public class BaseView : UserControl
    {
        /// <summary>
        /// Constructeur.
        /// </summary>
        protected BaseView() : base() { }

        /// <summary>
        /// Fonction ChangeComponent, elle permet de changer le composant au sein d'une vue.
        /// </summary>
        /// <param name="view">Vue ciblée.</param>
        /// <param name="component">Composant ciblé.</param>
        protected void ChangeComponent(Control view, Control component)
        {
            ClearComponent(view);
            component.Size = view.Size;
            //component.Dock = DockStyle.Fill;
            view.Controls.Add(component);
        }

        /// <summary>
        /// Fonction ClearComponent, elle permet d'effacer le/les composants affichés sur une vue.
        /// </summary>
        /// <param name="view">Vue ciblée.</param>
        protected void ClearComponent(Control view)
        {
            view.Controls.Clear();
        }
        /// <summary>
        /// Fonction ClearComponentRessources, elle permet de libérer les ressources utilisées par le/les composants d'une vue.
        /// </summary>
        /// <param name="view">Vue ciblée.</param>
        protected void ClearComponentRessources(Control view)
        {
            foreach (Control ctrl in view.Controls)
            {
                ctrl.Dispose();
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BaseView
            // 
            this.Name = "BaseView";
            this.Size = new System.Drawing.Size(0, 0);
            this.ResumeLayout(false);

        }
    }
}
