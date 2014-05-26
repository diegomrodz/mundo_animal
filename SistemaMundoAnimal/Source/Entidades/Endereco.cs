﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SistemaMundoAnimal.Source.Dados.Tipos;

namespace SistemaMundoAnimal.Source.Entidades {
    public class Endereco : Entidade {
        private string Pais;
        private string Estado;
        private string Cidade;
        private string _Endereco;
        private int NumeroEndereco;
        private string Bairro;
        private string Complemento;
        private TipoCEP CEP;

        private const int PaisMaxLength = 50;
        private const int EstadoLength = 2;
        private const int CidadeMaxLength = 100;
        private const int EnderecoMaxLength = 200;
        private const int BairroMaxLength = 120;
        private const int ComplementoMaxLength = 300;

        #region Endereco Getters e Setters

        public string GetPais() {
            return this.Pais;
        }

        public void SetPais(string pais) {
            if (pais.Length < PaisMaxLength) {
                this.Pais = pais;
            } else {
                throw new ArgumentException(pais + "não é um pais válido.");    
            }
        }

        public string GetEstado() {
            return this.Estado;    
        }

        public void SetEstado(string estado) {
            if (estado.Length == 2) {
                this.Estado = estado;
            } else {
                throw new ArgumentException(estado + "não é um estado válido."); 
            }     
        }

        public string GetCidade() {
            return this.Cidade;    
        }

        public void SetCidade(string cidade) {
            if (cidade.Length < CidadeMaxLength) {
                this.Cidade = cidade;
            } else {
                throw new ArgumentException(cidade + "não é um estado válido.");
            }
        }

        public string GetEndereco() {
            return this._Endereco;
        }

        public void SetEndereco(string endereco) {
            if (endereco.Length < EnderecoMaxLength) {
                this._Endereco = endereco;
            } else {
                throw new ArgumentException(endereco + "não é um endereço válido.");
            }
        }

        public int GetNumeroEndereco() {
            return this.NumeroEndereco;    
        }

        public void SetNumeroEndereco(int numero) {
            if (numero >= 1) {
                this.NumeroEndereco = numero;
            } else {
                throw new ArgumentException(numero + "não é um número válido.");
            }
        }

        public string GetBairro() {
            return this.Bairro;
        }

        public void SetBairro(string bairro) {
            if (bairro.Length < BairroMaxLength) {
                this.Bairro = bairro;
            } else {
                throw new ArgumentException(bairro + "não é um bairro válido."); 
            }
        }

        public string GetComplemento() {
            return this.Complemento;
        }

        public void SetComplemento(string complemento) {
            if (complemento.Length < ComplementoMaxLength) {
                this.Complemento = complemento;
            } else {
                throw new ArgumentException(complemento + "não é um complemento válido."); 
            }
        }

        public string GetCEP() {
            return this.CEP.ToString();
        }

        public void SetCEP(string cep) {
            if (TipoCEP.ValidarCEP(cep)) {
                this.CEP = new TipoCEP(cep);
            } else {
                throw new ArgumentException(cep + "não é um cep válido."); 
            }
        }

        #endregion
    }
}
