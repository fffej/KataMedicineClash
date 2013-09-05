
using System;
using System.Collections.Generic;
using KataMedicineClash;

public class Medicine {
    
    private ICollection<Prescription> prescriptions = new List<Prescription>();
    
    private readonly String name;

    public Medicine(String name) {
        this.name = name;
    }
    
    public void addPrescription(Prescription prescription) {
        this.prescriptions.Add(prescription);
    }
}
