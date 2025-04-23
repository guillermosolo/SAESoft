using System.Reflection;

namespace SAESoft.Utilitarios
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public static void EnableFullRedrawOnResize(this DataGridView dgv, Form form)
        {
            form.Resize += (sender, e) => dgv.Invalidate();
        }

        public static void EnableFullRedrawOnScroll(this DataGridView dgv)
        {
            dgv.Scroll += (sender, e) => dgv.Invalidate();
        }
    }
}
