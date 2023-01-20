/***********************************************************************
 * Module:  Bibliotheque.cs
 * Author:  benn
 * Purpose: Definition of the Class Bibliotheque
 ***********************************************************************/

using System;

public class Bibliotheque
{
   public void AjouterEmploye()
   {
      // TODO: implement
   }
   
   public void AjouterUsager()
   {
      // TODO: implement
   }
   
   public void AjouterLivre()
   {
      // TODO: implement
   }
   
   public void RechercherLivre()
   {
      // TODO: implement
   }
   
   public Boolean EmprunterLivre()
   {
      // TODO: implement
      return null;
   }
   
   public Boolean RendreLivre()
   {
      // TODO: implement
      return null;
   }

   public System.Collections.ArrayList employe;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetEmploye()
   {
      if (employe == null)
         employe = new System.Collections.ArrayList();
      return employe;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetEmploye(System.Collections.ArrayList newEmploye)
   {
      RemoveAllEmploye();
      foreach (Employe oEmploye in newEmploye)
         AddEmploye(oEmploye);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddEmploye(Employe newEmploye)
   {
      if (newEmploye == null)
         return;
      if (this.employe == null)
         this.employe = new System.Collections.ArrayList();
      if (!this.employe.Contains(newEmploye))
         this.employe.Add(newEmploye);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveEmploye(Employe oldEmploye)
   {
      if (oldEmploye == null)
         return;
      if (this.employe != null)
         if (this.employe.Contains(oldEmploye))
            this.employe.Remove(oldEmploye);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllEmploye()
   {
      if (employe != null)
         employe.Clear();
   }
   public System.Collections.ArrayList usager;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetUsager()
   {
      if (usager == null)
         usager = new System.Collections.ArrayList();
      return usager;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetUsager(System.Collections.ArrayList newUsager)
   {
      RemoveAllUsager();
      foreach (Usager oUsager in newUsager)
         AddUsager(oUsager);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddUsager(Usager newUsager)
   {
      if (newUsager == null)
         return;
      if (this.usager == null)
         this.usager = new System.Collections.ArrayList();
      if (!this.usager.Contains(newUsager))
         this.usager.Add(newUsager);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveUsager(Usager oldUsager)
   {
      if (oldUsager == null)
         return;
      if (this.usager != null)
         if (this.usager.Contains(oldUsager))
            this.usager.Remove(oldUsager);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllUsager()
   {
      if (usager != null)
         usager.Clear();
   }
   public System.Collections.ArrayList acquisition;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetAcquisition()
   {
      if (acquisition == null)
         acquisition = new System.Collections.ArrayList();
      return acquisition;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetAcquisition(System.Collections.ArrayList newAcquisition)
   {
      RemoveAllAcquisition();
      foreach (Acquisition oAcquisition in newAcquisition)
         AddAcquisition(oAcquisition);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddAcquisition(Acquisition newAcquisition)
   {
      if (newAcquisition == null)
         return;
      if (this.acquisition == null)
         this.acquisition = new System.Collections.ArrayList();
      if (!this.acquisition.Contains(newAcquisition))
         this.acquisition.Add(newAcquisition);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveAcquisition(Acquisition oldAcquisition)
   {
      if (oldAcquisition == null)
         return;
      if (this.acquisition != null)
         if (this.acquisition.Contains(oldAcquisition))
            this.acquisition.Remove(oldAcquisition);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllAcquisition()
   {
      if (acquisition != null)
         acquisition.Clear();
   }

   private String Nom;
   private String Adresse;
   private String Employes;
   private Single Usagers;
   private int NmbLivre;

}