using System.ComponentModel;

namespace ValidationComponents
{
    public partial class RequiredFieldValidator : BaseValidator
    {
        public RequiredFieldValidator()
        {
            InitializeComponent();
        }

        public RequiredFieldValidator(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override bool EvaluateIsValid()
        {
            // This is valid, as long as the value is not blank.
            return (ControlToValidate.Text.Trim() != "");
        }

    }
}
