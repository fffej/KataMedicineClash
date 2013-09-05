using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KataMedicineClash
{
    public class Patient {

        private ICollection<Medicine> medicines = new List<Medicine>();

        public void AddMedicine(Medicine medicine) {
            this.medicines.Add(medicine);
        }

        public Collection<DateTime> Clash(Collection<String> medicineNames) {
            return Clash(medicineNames, 90);
        }

        public Collection<DateTime> Clash(Collection<String> medicineNames, int daysBack)
        {
            // TODO: implement this method
            return null;
        }
    }
}
