using MVVMXamarin.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MVVMXamarin.Servicio
{
    public class PersonaServicio
    {
        public ObservableCollection <PersonaModel> personas {  get; set; }

        public PersonaServicio()
        {
            if(personas == null)
            {
                personas = new ObservableCollection<PersonaModel> ();
            }
        }

        public ObservableCollection<PersonaModel> consultar()
        {
            return personas;
        }

        public void Guardar(PersonaModel modelo)
        {
            personas.Add(modelo);
        }

        public void Modificar(PersonaModel modelo)
        {
            for(int i = 0; i < personas.Count; i++)
            {
                if (personas[i].Id == modelo.Id)
                    personas[i] = modelo;
            }
        }

        public void Eliminar(string idPersona)
        {
            PersonaModel modelo = personas.FirstOrDefault(p => p.Id == idPersona);
            personas.Remove(modelo);
        }
    }
}
