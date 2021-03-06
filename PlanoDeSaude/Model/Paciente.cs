﻿using System;
using System.Collections.Generic;
using System.Data;
using PlanoDeSaude.DAO;

namespace PlanoDeSaude.Model
{
    public class Paciente
    {
        #region ATRIBUTOS
        private string nome;
        private DateTime dtNascimento;
        private PlanoSaude objPlanoDeSaude = new PlanoSaude();
        private int tipoConveniado;
        private int id;
        #endregion

        #region PROPRIEDADES
        public PlanoSaude ObjPlanoDeSaude
        {
            get { return objPlanoDeSaude; }
            set { objPlanoDeSaude = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataNascimento
        {
            get { return dtNascimento; }
            set { dtNascimento = value; }
        }
        public int TipoConveniado
        {
            get { return tipoConveniado; }
            set { tipoConveniado = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        #endregion

        #region MÉTODOS
        public void Save()
        {
            PacienteDAO pDAO = new PacienteDAO();
            if (Id == 0)
            {
                pDAO.Insert(this);
            }
            else
            {
                pDAO.Update(this);
            }
        }
        public IList<Paciente> Buscar()
        {
            return new PacienteDAO().SelectAll();
        }
        public IList<Paciente> Buscar(string nome)
        {
            return new PacienteDAO().SelectByName(nome);
        }
        public Paciente Buscar(int id)
        {
            return new PacienteDAO().SelectById(id);
        }      
        public DataTable FormataListaPacientes(IList<Paciente> pacientes)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id", typeof(int));
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("Data de Nascimento", typeof(DateTime));
            dt.Columns.Add("Plano de Saúde", typeof(string));

            foreach (var item in pacientes)
            {
                dt.Rows.Add(item.id, item.Nome, item.dtNascimento, item.ObjPlanoDeSaude.Nome);
            }
            return dt;
        }
        #endregion
    }
}
