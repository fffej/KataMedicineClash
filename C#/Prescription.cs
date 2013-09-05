using System;

namespace KataMedicineClash
{
    public class Prescription {

        private DateTime dispenseDate = new DateTime();
        private int daysSupply = 30;

        public Prescription(DateTime dispenseDate, int daysSupply)
        {
            this.dispenseDate = dispenseDate;
            this.daysSupply = daysSupply;
        }

    }
}
