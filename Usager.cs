/***********************************************************************
 * Module:  Usager.cs
 * Author:  benn
 * Purpose: Definition of the Class Usager
 ***********************************************************************/

using System;

public class Usager
{
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
   
   public Boolean ProlongerEmprunt()
   {
      // TODO: implement
      return null;
   }
   
   public Boolean ReserverLivre()
   {
      // TODO: implement
      return null;
   }

   public System.Collections.ArrayList emprunt;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetEmprunt()
   {
      if (emprunt == null)
         emprunt = new System.Collections.ArrayList();
      return emprunt;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetEmprunt(System.Collections.ArrayList newEmprunt)
   {
      RemoveAllEmprunt();
      foreach (Emprunt oEmprunt in newEmprunt)
         AddEmprunt(oEmprunt);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddEmprunt(Emprunt newEmprunt)
   {
      if (newEmprunt == null)
         return;
      if (this.emprunt == null)
         this.emprunt = new System.Collections.ArrayList();
      if (!this.emprunt.Contains(newEmprunt))
         this.emprunt.Add(newEmprunt);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveEmprunt(Emprunt oldEmprunt)
   {
      if (oldEmprunt == null)
         return;
      if (this.emprunt != null)
         if (this.emprunt.Contains(oldEmprunt))
            this.emprunt.Remove(oldEmprunt);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllEmprunt()
   {
      if (emprunt != null)
         emprunt.Clear();
   }
   public System.Collections.ArrayList reservation;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetReservation()
   {
      if (reservation == null)
         reservation = new System.Collections.ArrayList();
      return reservation;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetReservation(System.Collections.ArrayList newReservation)
   {
      RemoveAllReservation();
      foreach (Reservation oReservation in newReservation)
         AddReservation(oReservation);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddReservation(Reservation newReservation)
   {
      if (newReservation == null)
         return;
      if (this.reservation == null)
         this.reservation = new System.Collections.ArrayList();
      if (!this.reservation.Contains(newReservation))
         this.reservation.Add(newReservation);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveReservation(Reservation oldReservation)
   {
      if (oldReservation == null)
         return;
      if (this.reservation != null)
         if (this.reservation.Contains(oldReservation))
            this.reservation.Remove(oldReservation);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllReservation()
   {
      if (reservation != null)
         reservation.Clear();
   }

   private String Nom;
   private String Adresse;
   private String NumeroTelephone;
   private int NbrLivresEmpruntes;

}