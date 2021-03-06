// ***********************************************************************
// Assembly         : ACBr.Net.Boleto
// Author           : RFTD
// Created          : 04-21-2014
//
// Last Modified By : RFTD
// Last Modified On : 05-05-2014
// ***********************************************************************
// <copyright file="BancoBanrisul.cs" company="ACBr.Net">
//     Copyright (c) ACBr.Net. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Text;
using ACBr.Net.Boleto.Enums;
using ACBr.Net.Boleto.Utils;
using ACBr.Net.Core;
using ACBr.Net.Core.Exceptions;
using ACBr.Net.Core.Extensions;

#region COM Interop Attributes

#if COM_INTEROP
using System.Runtime.InteropServices;
#endif


#endregion COM Interop Attributes

namespace ACBr.Net.Boleto.Bancos
{
    #region COM Interop Attributes

#if COM_INTEROP

	[ComVisible(true)]
	[Guid("468A3233-787C-446E-A016-3098141B8D35")]
	[ClassInterface(ClassInterfaceType.AutoDual)]

#endif

    #endregion COM Interop Attributes
    /// <summary>
    /// Classe BancoBanrisul. This class cannot be inherited.
    /// </summary>
    public sealed class BancoBanrisul : BancoBase
    {
        #region Constructor

        /// <summary>
        /// Inicializa uma nova instancia da classe <see cref="BancoBanrisul" />.
        /// </summary>
        /// <param name="parent">Classe Banco.</param>
        internal BancoBanrisul(Banco parent)
            : base(parent)
        {
            TipoCobranca = TipoCobranca.Banrisul;
            Digito = 8;
            Nome = "Banrisul";
            Numero = 41;
            TamanhoMaximoNossoNum = 8;
            TamanhoAgencia = 4;
            TamanhoConta = 7;
            TamanhoCarteira = 1;
            OrientacoesBanco.Clear();
            OrientacoesBanco.Add("SAC       BANRISUL - 0800 646 1515");
            OrientacoesBanco.Add("OUVIDORIA BANRISUL - 0800 644 2200");  
        }

        #endregion Constructor

        #region Propriedades
        #endregion Propriedades

        #region Methods

        /// <summary>
        /// Retorna a descri��o do TipoOcorrencia.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <returns>System.String.</returns>
        public override string TipoOcorrenciaToDescricao(TipoOcorrencia tipo)
        {
            var codOcorrencia = (int)tipo;
            switch (Banco.Parent.LayoutRemessa)
            {
                case LayoutRemessa.CNAB240:
                    switch (codOcorrencia)
                    {
                        case 2: return "02-Entrada confirmada";
                        case 3: return "03-Entrada rejeitada";
                        case 4: return "04-Baixa de t�tulo liquidado por edital";
                        case 6: return "06-Liquida��o normal";
                        case 7: return "07-Liquida��o parcial";
                        case 8: return "08-Baixa por pagamento, liquida��o de saldo";
                        case 9: return "09-Devolu��o autom�tica";
                        case 10: return "10-Baixado conforme instru��es da ag�ncia";
                        case 11: return "11-Arquivo levantamento";
                        case 12: return "12-Abatimento concedido";
                        case 13: return "13-Abatimento cancelado";
                        case 14: return "14-Vencimento alterado";
                        case 15: return "15-Liquida��o em cart�rio";
                        case 16: return "16-Altera��o de dados";
                        case 18: return "18-Altera��o de instru��es";
                        case 19: return "19-Confirma��o recebimento instru��o de protesto";
                        case 20: return "20-Confirma��o recebimento instru��o susta��o de protesto";
                        case 21: return "21-Aguardando autoriza��o para protesto por edital";
                        case 22: return "22-Protesto sustado por altera��o de vencimento e prazo de cart�rio";
                        case 23: return "23-Entrada do t�tulo em cart�rio";
                        case 25: return "25-Devolu��o, liquidado anteriormente";
                        case 26: return "26-Devolvido pelo cart�rio, erro de informa��o";
                        case 30: return "30-Cobran�a a creditar(liquida��o em tr�nsito)";
                        case 31: return "31-T�tulo em tr�nsito pago em cart�rio";
                        case 32: return "32-Reembolso e tranfer�ncia Desconto e Vendou ou carteira em garantia";
                        case 33: return "33-Reembolso e devolu��o Desconto e Vendor";
                        case 34: return "34-Reembolso n�o efetuado por falta de saldo";
                        case 40: return "40-Baixa de t�tulos protestados";
                        case 41: return "41-Despesa de aponte";
                        case 42: return "42-Altera��o de t�tulo";
                        case 43: return "43-Rela��o de t�tulos";
                        case 44: return "44-Manuten��o mensal";
                        case 45: return "45-Susta��o de cart�rio e envio de t�tulo a cart�rio";
                        case 46: return "46-Fornecimento de formul�rio pr�-impresso";
                        case 47: return "47-Confirma��o de entrada - Pagador DDA";
                        case 68: return "68-Acerto de dados do rateio de cr�dito";
                        case 69: return "69-Cancelamento dos dados do rateio";
                        default: return "00-Outras ocorr�ncias";
                    }

                case LayoutRemessa.CNAB400:
                    switch (codOcorrencia)
                    {
                        case 2: return "02-Entrada confirmada";
                        case 3: return "03-Entrada rejeitada";
                        case 4: return "04-Baixa de t�tulo liquidado por edital";
                        case 6: return "06-Liquida��o normal";
                        case 7: return "07-Liquida��o parcial";
                        case 8: return "08-Baixa por pagamento, liquida��o de saldo";
                        case 9: return "09-Devolu��o autom�tica";
                        case 10: return "10-Baixado conforme instru��es da ag�ncia";
                        case 11: return "11-Arquivo levantamento";
                        case 12: return "12-Abatimento concedido";
                        case 13: return "13-Abatimento cancelado";
                        case 14: return "14-Vencimento alterado";
                        case 15: return "15-Liquida��o em cart�rio";
                        case 16: return "16-Altera��o de dados";
                        case 18: return "18-Altera��o de instru��es";
                        case 19: return "19-Confirma��o recebimento instru��o de protesto";
                        case 20: return "20-Confirma��o recebimento instru��o susta��o de protesto";
                        case 21: return "21-Aguardando autoriza��o para protesto por edital";
                        case 22: return "22-Protesto sustado por altera��o de vencimento e prazo de cart�rio";
                        case 23: return "23-Entrada do t�tulo em cart�rio";
                        case 25: return "25-Devolu��o, liquidado anteriormente";
                        case 26: return "26-Devolvido pelo cart�rio, erro de informa��o";
                        case 30: return "30-Cobran�a a creditar(liquida��o em tr�nsito)";
                        case 31: return "31-T�tulo em tr�nsito pago em cart�rio";
                        case 32: return "32-Reembolso e tranfer�ncia Desconto e Vendou ou carteira em garantia";
                        case 33: return "33-Reembolso e devolu��o Desconto e Vendor";
                        case 34: return "34-Reembolso n�o efetuado por falta de saldo";
                        case 40: return "40-Baixa de t�tulos protestados";
                        case 41: return "41-Despesa de aponte";
                        case 42: return "42-Altera��o de t�tulo";
                        case 43: return "43-Rela��o de t�tulos";
                        case 44: return "44-Manuten��o mensal";
                        case 45: return "45-Susta��o de cart�rio e envio de t�tulo a cart�rio";
                        case 46: return "46-Fornecimento de formul�rio pr�-impresso";
                        case 47: return "47-Confirma��o de entrada - Pagador DDA";
                        case 68: return "68-Acerto de dados do rateio de cr�dito";
                        case 69: return "69-Cancelamento dos dados do rateio"; 
                        default: return "00-Outras ocorr�ncias";
                    }

                default: return "00-Outras ocorr�ncias";
            }
        }

        /// <summary>
        /// Codigo de ocorrencia para TipoOcorrencia.
        /// </summary>
        /// <param name="codOcorrencia">Codigo.</param>
        /// <returns>TipoOcorrencia.</returns>
        public override TipoOcorrencia CodOcorrenciaToTipo(int codOcorrencia)
        {
            switch (Banco.Parent.LayoutRemessa)
            {
                case LayoutRemessa.CNAB240:
                    switch(codOcorrencia)
                    {
                        case 2: return TipoOcorrencia.RetornoRegistroConfirmado;
                        case 3: return TipoOcorrencia.RetornoRegistroRecusado;
                        case 6: return TipoOcorrencia.RetornoLiquidado;
                        case 7: return TipoOcorrencia.RetornoLiquidadoParcialmente;  //Liquida��o Parcial
                        case 9: return TipoOcorrencia.RetornoBaixado;
                        case 11: return TipoOcorrencia.RetornoTituloEmSer;
                        case 12: return TipoOcorrencia.RetornoRecebimentoInstrucaoConcederAbatimento;
                        case 13: return TipoOcorrencia.RetornoRecebimentoInstrucaoCancelarAbatimento;
                        case 14: return TipoOcorrencia.RetornoRecebimentoInstrucaoAlterarVencimento;
                        case 17: return TipoOcorrencia.RetornoLiquidadoAposBaixaOuNaoRegistro;
                        case 19: return TipoOcorrencia.RetornoRecebimentoInstrucaoProtestar;
                        case 20: return TipoOcorrencia.RetornoRecebimentoInstrucaoSustarProtesto;
                        case 23: return TipoOcorrencia.RetornoEncaminhadoACartorio;
                        case 25: return TipoOcorrencia.RetornoBaixaPorProtesto;
                        case 26: return TipoOcorrencia.RetornoInstrucaoRejeitada;
                        case 28: return TipoOcorrencia.RetornoDebitoTarifas;
                        case 30: return TipoOcorrencia.RetornoAlteracaoDadosRejeitados;
                        default: return TipoOcorrencia.RetornoOutrasOcorrencias;
                    }

                case LayoutRemessa.CNAB400:
                    switch (codOcorrencia)
                    {
                        case 2: return TipoOcorrencia.RetornoRegistroConfirmado;
                        case 3: return TipoOcorrencia.RetornoRegistroRecusado;
                        case 6: return TipoOcorrencia.RetornoLiquidado;
                        case 7: return TipoOcorrencia.RetornoLiquidadoParcialmente;
                        case 8: return TipoOcorrencia.RetornoBaixadoViaArquivo;
                        case 10: return TipoOcorrencia.RetornoBaixadoInstAgencia;
                        case 12: return TipoOcorrencia.RetornoAbatimentoConcedido;
                        case 13: return TipoOcorrencia.RetornoAbatimentoCancelado;
                        case 14: return TipoOcorrencia.RetornoVencimentoAlterado;
                        case 15: return TipoOcorrencia.RetornoLiquidadoEmCartorio;
                        case 19: return TipoOcorrencia.RetornoRecebimentoInstrucaoProtestar;
                        case 20: return TipoOcorrencia.RetornoRecebimentoInstrucaoSustarProtesto;
                        case 23: return TipoOcorrencia.RetornoEntradaEmCartorio;
                        default: return TipoOcorrencia.RetornoOutrasOcorrencias;
                    }

                default: return TipoOcorrencia.RetornoOutrasOcorrencias;
            }
        }

        /// <summary>
        /// TipoOcorrencia para codigo.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <returns>System.String.</returns>
        public override string TipoOCorrenciaToCod(TipoOcorrencia tipo)
        {
            switch (Banco.Parent.LayoutRemessa)
            {
                //Conferir com manual pois foi baseado no CNAB400
                case LayoutRemessa.CNAB240:
                    switch (tipo)
                    {
                        case TipoOcorrencia.RetornoRegistroConfirmado: return "02";
                        case TipoOcorrencia.RetornoRegistroRecusado: return "03";
                        case TipoOcorrencia.RetornoLiquidado: return "06";
                        case TipoOcorrencia.RetornoLiquidadoParcialmente: return "07";
                        case TipoOcorrencia.RetornoBaixadoInstAgencia: return "10";
                        case TipoOcorrencia.RetornoAbatimentoConcedido: return "12";
                        case TipoOcorrencia.RetornoAbatimentoCancelado: return "13";
                        case TipoOcorrencia.RetornoVencimentoAlterado: return "14";
                        case TipoOcorrencia.RetornoLiquidadoEmCartorio: return "15";
                        case TipoOcorrencia.RetornoRecebimentoInstrucaoProtestar: return "19";
                        case TipoOcorrencia.RetornoRecebimentoInstrucaoSustarProtesto: return "20";
                        case TipoOcorrencia.RetornoEntradaEmCartorio: return "23";  
                        default: return "00";
                    }

                case LayoutRemessa.CNAB400:
                    switch (tipo)
                    {
                        case TipoOcorrencia.RetornoRegistroConfirmado: return "02";
                        case TipoOcorrencia.RetornoRegistroRecusado: return "03";
                        case TipoOcorrencia.RetornoLiquidado: return "06";
                        case TipoOcorrencia.RetornoLiquidadoParcialmente: return "07";
                        case TipoOcorrencia.RetornoBaixadoInstAgencia: return "10";
                        case TipoOcorrencia.RetornoAbatimentoConcedido: return "12";
                        case TipoOcorrencia.RetornoAbatimentoCancelado: return "13";
                        case TipoOcorrencia.RetornoVencimentoAlterado: return "14";
                        case TipoOcorrencia.RetornoLiquidadoEmCartorio: return "15";
                        case TipoOcorrencia.RetornoRecebimentoInstrucaoProtestar: return "19";
                        case TipoOcorrencia.RetornoRecebimentoInstrucaoSustarProtesto: return "20";
                        case TipoOcorrencia.RetornoEntradaEmCartorio: return "23";  
                        default: return "00";
                    }

                default: return "00";
            }
        }

        /// <summary>
        /// Cods the motivo rejeicao to descricao.
        /// </summary>
        /// <param name="tipo">The tipo.</param>
        /// <param name="codMotivo">The cod motivo.</param>
        /// <returns>System.String.</returns>
        public static string CodMotivoRejeicaoToDescricao(TipoOcorrencia tipo, string codMotivo)
        {
            switch (tipo)
            {
                case TipoOcorrencia.RetornoRegistroConfirmado:
                    if (codMotivo == "A4")
                        return "Sacado DDA";
		            return string.Format("{0:00} - Outros Motivos", codMotivo);

	            case TipoOcorrencia.RetornoLiquidado:
                case TipoOcorrencia.RetornoLiquidadoAposBaixaOuNaoRegistro:
                    switch (codMotivo.ToInt32())
                    {
                        case 1: return "Por saldo - Reservado";
                        case 2: return "Por conta (parcial)";
                        case 3: return "No pr�prio banco";
                        case 4: return "Compensa��o Eletr�nica";
                        case 5: return "Compensa��o Convencional";
                        case 6: return "Por meio Eletr�nico";
                        case 7: return "Reservado";
                        case 8: return "Em Cart�rio";
                        default: return string.Format("{0:00} - Outros Motivos", codMotivo);
                    }

                case TipoOcorrencia.RetornoBaixado:
                    switch(codMotivo.ToInt32(0))
                    {
                        case 0:
                            if (codMotivo == "AA")
                                return "Baixa por pagamento";
		                    return "00 - Outros Motivos";
	                    case 9: return "Comandado Banco";
                        case 10: return "Comandado cliente Arquivo";
                        case 11: return "Comandado cliente On-Line";
                        case 12: return "Decurso prazo - cliente";
  
                        default: return string.Format("{0:00} - Outros Motivos", codMotivo);
                    }

                case TipoOcorrencia.RetornoTituloEmSer:
                    switch(codMotivo.ToInt32())
                    {
                        case 70: return "T�tulo n�o selecionado por erro no CNPJ/CPF ou endere�o";
                        case 76: return "Banco aguarda c�pia autenticada do documento";
                        case 77: return "T�tulo selecionado falta seu n�mero";
                        case 78: return "T�tulo rejeitado pelo cart�rio por estar irregular";
                        case 79: return "T�tulo n�o selecionado - pra�a n�o atendida";
                        case 80: return "Cart�rio aguarda autoriza��o para protestar por edital";
                        case 90: return "Protesto sustado por solicita��o do cedente";
                        case 91: return "Protesto sustado por altera��o no vencimento";
                        case 92: return "Aponte cobrado de t�tulo sustado";
                        case 93: return "Protesto sustado por altera��o no prazo do protesto";
                        case 95: return "Entidade P�blica";
                        case 97: return "T�tulo em cart�rio";
                        default: return string.Format("{0:00} - Outros Motivos", codMotivo);
                    }

                case TipoOcorrencia.RetornoDebitoTarifas: 
                    switch(codMotivo.ToInt32(0))
                    {
                        case 0:
                            if (codMotivo == "AA")
                                return "Tarifa de formul�rio Pr�-Impresso";
		                    return "00 - Outros Motivos";
	                    case 1: return "Tarifa de extrato de posi��o";
                        case 2: return "Tarifa de manuten��o de t�tulo vencido";
                        case 3: return "Tarifa de susta��o e envio para cart�rio";
                        case 4: return "Tarifa de protesto";
                        case 5: return "Tarifa de outras instru��es";
                        case 6: return "Tarifa de outras ocorr�ncias(Registro/Liquida��o)";
                        case 7: return "Tarifa de envio de duplicata ao sacado";
                        case 8: return "Custas de protesto";
                        case 9: return "Custas de Susta��o de Protesto";
                        case 10: return "Custas do cart�rio distribuidor";
                        case 11: return "Reservado"; 
                        default: return string.Format("{0:00} - Outros Motivos", codMotivo);
                    }


                default: return string.Format("{0:00} - Outros Motivos", codMotivo);
            }
        }

        /// <summary>
        /// Montars the campo codigo cedente.
        /// </summary>
        /// <param name="titulo">The titulo.</param>
        /// <returns>System.String.</returns>
        public override string MontarCampoCodigoCedente(Titulo titulo)
        {
            return string.Format("{0}-{1}/{2}.{3}.{4}", titulo.Parent.Cedente.Agencia.Substring(0, 4),
                titulo.Parent.Cedente.AgenciaDigito, titulo.Parent.Cedente.CodigoCedente.Substring(0, 6),
                titulo.Parent.Cedente.CodigoCedente.Substring( 6, 1), 
                titulo.Parent.Cedente.CodigoCedente.Substring( 7, 2));
        }

        /// <summary>
        /// Montars the campo nosso numero.
        /// </summary>
        /// <param name="titulo">The titulo.</param>
        /// <returns>System.String.</returns>
        public override string MontarCampoNossoNumero(Titulo titulo)
        {
            var ret = titulo.NossoNumero.StringFill(8, '0');
            return string.Format("{0}.{1}", ret, CalculaDigitosChaveAsbace(ret));
        }

        /// <summary>
        /// Montars the codigo barras.
        /// </summary>
        /// <param name="titulo">The titulo.</param>
        /// <returns>System.String.</returns>
        public override string MontarCodigoBarras(Titulo titulo)
        {
            string modalidade;
            if(titulo.Parent.Cedente.ResponEmissao == ResponEmissao.CliEmite)
                modalidade = "2";
            else
                modalidade = "1";

            var campoLivre = string.Format("{0}1{1}{2}{3}40", modalidade, titulo.Parent.Cedente.Agencia.StringFill( 4, '0').Trim(),
                        titulo.Parent.Cedente.CodigoCedente.OnlyNumbers().StringFill(7, '0'), titulo.NossoNumero.StringFill(8, '0'));

            campoLivre += CalculaDigitosChaveAsbace(campoLivre);
            var codigoBarras = string.Format("{0:000}9{1}{2}{3}", Numero, titulo.Vencimento.CalcularFatorVencimento(),
                        titulo.ValorDocumento.ToDecimalString(10), campoLivre);

            var digitoCodBarras = CalcularDigitoCodigoBarras(codigoBarras);

            if (digitoCodBarras.ToInt32() == 0 || digitoCodBarras.ToInt32() > 9)
                digitoCodBarras = "1";

            return codigoBarras.Insert(4, digitoCodBarras);
        }

        /// <summary>
        /// Calculas the digitos chave asbace.
        /// </summary>
        /// <param name="chaveAsbaceSemDigito">The chave asbace sem digito.</param>
        /// <returns>System.String.</returns>
        private static string CalculaDigitosChaveAsbace(string chaveAsbaceSemDigito)
        {
            //Calcula o primeiro d�gito.
            //O c�lculo � parecido com o da rotina Modulo10. Por�m, n�o faz diferen�a o
            //n�mero de d�gitos de cada subproduto.
            //Se o resultado da opera��o for 0 (ZERO) o d�gito ser� 0 (ZERO). Caso contr�rio,
            //o d�gito ser� igual a 10 - Resultado.    
            Func<string, int> calcularDigito1 = chaveAsbace =>
            {
                var soma = 0;
                var peso = 2;
                var tamanho = chaveAsbace.Length - 1;
                for (var i = 0; i < tamanho; i++)
                {
                    var auxiliar = chaveAsbace[tamanho - i].ToInt32() * peso;
                    if (auxiliar > 9)
                        auxiliar -= 9;
                    soma += auxiliar;
                    peso = peso == 1 ? 2 : 1;
                }
                var digito = soma % 10;
                if (digito == 0)
                    return digito;
	           
				return 10 - digito;
            };

            Func<string, int, int> calcularDigito2 = null;
            calcularDigito2 = (chaveAsbace, digito) =>
            {
                var cDigito = new CalcDigito();
                cDigito.CalculoPadrao();
                cDigito.MultiplicadorFinal = 7;
                cDigito.Documento = String.Format("{0}{1}", chaveAsbace, digito);
                cDigito.Calcular();
                var dig2 = cDigito.DigitoFinal;

                //Se d�gito2 = 1, deve-se incrementar o d�gito1 e recalcular o d�gito2}
                if (dig2 == 1)
                {
                    digito++;
                    //Se, ap�s incrementar o d�gito1, ele ficar maior que 9, deve-se substitu�-lo por 0
                    if (digito > 9)
                        digito = 0;

                    dig2 = calcularDigito2(chaveAsbace, digito);
                }
                else
                    if (dig2 > 1)
                        dig2 = 11 - dig2;
                return dig2;
            };

            var digito1 = calcularDigito1(chaveAsbaceSemDigito);
            var digito2 = calcularDigito2(chaveAsbaceSemDigito, digito1);

            return string.Format("{0}{1}", digito1, digito2);
        }

        /// <summary>
        /// Gerar registro header do arquivo CNAB400.
        /// </summary>
        /// <param name="numeroRemessa">Numero da remessa.</param>
        /// <param name="aRemessa">A remessa.</param>
        public override void GerarRegistroHeader400(int numeroRemessa, List<string> aRemessa)
        {
            var cd = Banco.Parent.Cedente.CodigoCedente.OnlyNumbers();
            var wLinha = new StringBuilder();
            wLinha.Append('0');                                                     // ID do Registro
            wLinha.Append('1');                                                     // ID do Arquivo( 1 - Remessa)
            wLinha.Append("REMESSA");                                               // Literal de Remessa
            wLinha.Append("".StringFill(17));                                         // Brancos
            wLinha.Append(Banco.Parent.Cedente.Agencia.Trim().FillRight(4, '0'));
            wLinha.Append(cd.StringFill(9, '0'));                                     // C�digo Agencia + Cedente AAAACCCCCCCCC
            wLinha.Append("".StringFill(7));                                          // Brancos
            wLinha.Append(Banco.Parent.Cedente.Nome.FillRight(30));                  // Nome da empresa Cedente
            wLinha.Append("041BANRISUL".FillLeft(11));                               // C�digo e Nome do Banco Constante(041Banrisul)
            wLinha.Append("".StringFill(7));                                          // Brancos
            wLinha.AppendFormat("{0:ddmmyy}", DateTime.Now);                        // Data de grava��o do arquivo
            wLinha.Append("".StringFill(9));                                          // Brancos
            wLinha.Append("".FillRight(4));                                          // C�digo do servi�o - Somente para carteiras R, S e X
            wLinha.Append(' ');                                                     // Brancos
            wLinha.Append("".FillRight(1));                                          // Tipo de processamento - Somente para carteiras R, S e X
            wLinha.Append(' ');                                                     // Brancos
            wLinha.Append("".FillRight(10));                                         // C�digo do cliente no Office Banking - Somente para carteiras R, S e X
            wLinha.Append("".FillRight(268));                                        // Brancos
            wLinha.AppendFormat("{0:000000}", 1);                                   // Constante (000001)

            aRemessa.Add(wLinha.ToString().ToUpper());
        }

        /// <summary>
        /// Gerars the registro transacao400.
        /// </summary>
        /// <param name="titulo">The titulo.</param>
        /// <param name="aRemessa">A remessa.</param>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override void GerarRegistroTransacao400(Titulo titulo, List<string> aRemessa)
        {
            //Pegando C�digo da Ocorrencia
            string ocorrencia;
            switch (titulo.OcorrenciaOriginal.Tipo)
            {
                case TipoOcorrencia.RemessaBaixar: ocorrencia = "02"; break; //Pedido de Baixa
                case TipoOcorrencia.RemessaConcederAbatimento: ocorrencia = "04"; break;//Concess�o de Abatimento
                case TipoOcorrencia.RemessaCancelarAbatimento: ocorrencia = "05"; break;//Cancelamento de Abatimento concedido
                case TipoOcorrencia.RemessaAlterarVencimento: ocorrencia = "06"; break;//Altera��o de vencimento
                case TipoOcorrencia.RemessaProtestar: ocorrencia = "09"; break;//Pedido de protesto
                case TipoOcorrencia.RemessaSustarProtesto: ocorrencia = "10"; break;//Susta��o de protesto
                default: ocorrencia = "01"; break;
            }

            //Pegando o tipo de boleto
            string tipoBoleto;
            switch (titulo.Parent.Cedente.ResponEmissao)
            {
                case ResponEmissao.BancoReemite: tipoBoleto = "04"; break; //Cobran�a Direta
                default: tipoBoleto = "08"; break; //Cobran�a credenciada Banrisul
            }

            //Pegando o Aceite do Titulo }
            var tipoAceite = string.Empty;
            switch (titulo.Aceite)
            {
                case AceiteTitulo.Sim: tipoAceite = "A"; break;
                case AceiteTitulo.Nao: tipoAceite = "N"; break;
            }

            //Pegando Tipo de Sacado
            string tipoSacado;
            switch (titulo.Sacado.Pessoa)
            {
                case Pessoa.Fisica:
                    tipoSacado = "01";
                    break;

                case Pessoa.Juridica:
                    tipoSacado = "02";
                    break;

                default:
                    tipoSacado = "99";
                    break;
            }

            //Pegando Tipo de Cobran�a - Tipo de Carteira
            string tipoCobranca;
            switch (titulo.Parent.Cedente.CaracTitulo)
            {
                case CaracTitulo.Vendor:
                    tipoCobranca = "F";
                    break;

                case CaracTitulo.Vinculada:
                    tipoCobranca = "C";
                    break;

                default:
                    tipoCobranca = "1";
                    break;
            }

            if (string.IsNullOrEmpty(titulo.CodigoMora.ToString()))
                titulo.CodigoMora = '0';      //0-Valor Diario, 1-Taxa Mensal

            //Instru��es
            //Se tiver protesto
            if (titulo.DataProtesto.HasValue && titulo.DataProtesto.Value > titulo.Vencimento)
            {
                if (string.IsNullOrEmpty(titulo.Instrucao1.Trim()))
                    titulo.Instrucao1 = "09"; //Protestar caso n�o pago em NN dias ap�s vencimento.
            }
            else
                titulo.Instrucao3 = "23"; //N�o Protestar

            if(titulo.PercentualMulta > 0)
                if (string.IsNullOrEmpty(titulo.Instrucao2.Trim()))
                    titulo.Instrucao2 = "18"; //Apos NN dias vencimento com percentual multa

            var cd = titulo.Parent.Cedente.CodigoCedente.OnlyNumbers();
            var wLinha = new StringBuilder();
            wLinha.Append('1');                                                                      // ID Registro(1-Constante)
            wLinha.Append("".FillRight(16));                                                          // Brancos
            wLinha.Append((titulo.Parent.Cedente.Agencia.Substring(0, 4) + cd).FillRight(13, '0'));   // Codigo da Agencia e Cedente AAAACCCCCCCCC
            wLinha.Append("".FillRight(7));                                                           // Brancos
            wLinha.Append("".FillRight(25));                                                          // Identifica��o do t�tulo para o cedente (usado no arquivo de retorno)
            wLinha.Append(titulo.NossoNumero.FillLeft(8, '0'));
            wLinha.Append(CalculaDigitosChaveAsbace(titulo.NossoNumero));                            // Nosso N�mero
            wLinha.Append("".FillRight(32));                                                          // Mensagem no bloqueto
            wLinha.Append("".FillRight(3));                                                           // Brancos
            wLinha.Append(tipoCobranca);                                                             // Tipo de Carteira (Simples, Vinculada, Descontada, Vendor)
            wLinha.Append(ocorrencia);                                                               // C�digo de ocorr�ncia
            wLinha.Append(titulo.NumeroDocumento.FillLeft(10));                                       // Seu N�mero
            wLinha.AppendFormat("{0:ddmmyy}", titulo.Vencimento);                                    // Data de vencimento do t�tulo
            wLinha.Append(titulo.ValorDocumento.ToDecimalString());                                  // Valor do t�tulo
            wLinha.Append("041");                                                                    // Constante (041)
            wLinha.Append("".FillRight(5));                                                           // Brancos
            wLinha.Append(tipoBoleto);                                                               // Tipo de Documento (04-Cobran�a Direta, 06-Cobran�a Escritural, 08-Cobran�a credenciada Banrisul, 09-T�tulos de terceiros)
            wLinha.Append(tipoAceite);                                                               // C�digo de aceite (A, N)
            wLinha.AppendFormat("{0:ddmmyy}", titulo.DataDocumento);                                 // Data de Emiss�o do t�tulo
            wLinha.Append(titulo.Instrucao1.Trim().FillRight(2));                                     // 1� Instru��o
            wLinha.Append(titulo.Instrucao2.Trim().FillRight(2));                                     // 2� Instru��o
            wLinha.Append(titulo.CodigoMora);                                                        // C�digo de mora (0=Valor di�rio; 1=Taxa Mensal)
            wLinha.Append(titulo.ValorMoraJuros.ToDecimalString(12));                                // Valor ao dia ou Taxa Mensal de juros
            
            wLinha.Append(titulo.DataDesconto.HasValue ?
                string.Format("{0:ddmmyy}", titulo.DataDesconto) : "000000");                       // Data para concess�o de desconto

            wLinha.Append(titulo.ValorDesconto.ToDecimalString());                                  // Valor do desconto a ser concedido
            wLinha.Append(titulo.ValorIOF.ToDecimalString());                                       // Valor IOF (para carteira "X" �: taxa juros + IOF + zeros)
            wLinha.Append(titulo.ValorAbatimento.ToDecimalString());                                // Valor do abatimento
            wLinha.Append(tipoSacado);                                                              // Tipo do Sacado (01-CPF, 02-CNPJ, 03-Outros)
            wLinha.Append(titulo.Sacado.CNPJCPF.OnlyNumbers().FillRight(14, '0'));                   // N�mero da inscri��o do Sacado (CPF, CNPJ)
            wLinha.Append(titulo.Sacado.NomeSacado.FillLeft(35));                                    // Nome do Sacado
            wLinha.Append("".FillRight(5));                                                          // Brancos
            wLinha.Append((titulo.Sacado.Logradouro+' '+
                    titulo.Sacado.Numero+' '+
                    titulo.Sacado.Complemento).FillLeft(40));                                        // Endere�o Sacado
            wLinha.Append("".FillRight(7));                                                          // Brancos
            wLinha.Append(Math.Round(titulo.PercentualMulta * 10).ToString().ZeroFill(3));          // Taxa de multa ap�s o Vencimento -- estava '000' � apenas uma casa decimal
            wLinha.Append("00");                                                                    // N� dias para multa ap�s o vencimento (00 considera-se Ap�s Vencimento)
            wLinha.Append(titulo.Sacado.CEP.OnlyNumbers().FillLeft(8, '0'));                         // CEP
            wLinha.Append(titulo.Sacado.Cidade.FillLeft(15));                                        // Cidade do Sacado
            wLinha.Append(titulo.Sacado.UF.FillLeft(2));                                             // UF do Sacado
            wLinha.Append("0000");                                                                  // Taxa ao dia para pagamento antecipado
            wLinha.Append("".FillRight(1));                                                          // Brancos
            wLinha.Append("0000000000000");                                                         // Valor para c�lculo de desconto
            wLinha.Append(titulo.DataProtesto.HasValue && titulo.DataProtesto > titulo.Vencimento ?
                      (titulo.DataProtesto.Value - titulo.Vencimento).Days.ToString().FillRight(2, '0')
                      : "00");                                                                      // Dias para protesto/devolu��o autom�tica
             wLinha.Append("".FillRight(23));                                                        // Brancos
             wLinha.AppendFormat("{0:000000}", aRemessa.Count + 1);  

            aRemessa.Add(wLinha.ToString().ToUpper()); 
        }

        /// <summary>
        /// Gerar registro trailler CNAB400.
        /// </summary>
        /// <param name="aRemessa">A remessa.</param>
        public override void GerarRegistroTrailler400(List<string> aRemessa)
        {
			decimal aTotal = 0;
			foreach (var titulo in Banco.Parent.ListadeBoletos)
				aTotal += titulo.ValorDocumento;

            var wLinha = new StringBuilder();
            wLinha.Append('9');                                     // Constante (9)
            wLinha.Append("".FillRight(26));                        // Brancos
            wLinha.Append(aTotal.ToDecimalString());                // Total Somat�rio dos valores dos t�tulos
            wLinha.Append("".FillRight(354));                       // Brancos
            wLinha.AppendFormat("{0:000000}", aRemessa.Count + 1);  // N�mero sequencial do Registro

            aRemessa.Add(wLinha.ToString().ToUpper());
        }

        /// <summary>
        /// Lers the retorno400.
        /// </summary>
        /// <param name="aRetorno">A retorno.</param>
        /// <exception cref="ACBrException">
        /// Ag�ncia\\Conta do arquivo inv�lido
        /// </exception>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override void LerRetorno400(List<string> aRetorno)
        {
            Guard.Against<ACBrException>(aRetorno[0].ExtrairInt32DaPosicao(77, 79) != Numero,
			"{0} n�o � um arquivo de retorno do {1}", Banco.Parent.NomeArqRetorno, Nome);

            TamanhoMaximoNossoNum = 10;
            var rCedente = aRetorno[0].ExtrairDaPosicao(47, 76);
            var rAgencia = aRetorno[0].ExtrairDaPosicao(27, 30).Trim();
            var rConta = aRetorno[0].ExtrairDaPosicao(31, 39).Trim();
                        
            Banco.Parent.NumeroArquivo = aRetorno[0].ExtrairInt32DaPosicao(386, 395);
            Banco.Parent.DataArquivo = aRetorno[0].ExtrairDataDaPosicao(95, 100);

            Guard.Against<ACBrException>(Banco.Parent.LeCedenteRetorno && (rAgencia != Banco.Parent.Cedente.Agencia.OnlyNumbers() ||
                rConta != Banco.Parent.Cedente.Conta.OnlyNumbers()), "Ag�ncia\\Conta do arquivo inv�lido");
        
            Banco.Parent.Cedente.Nome = rCedente;
            Banco.Parent.Cedente.CNPJCPF = string.Empty;
            Banco.Parent.Cedente.Convenio = string.Empty;
            Banco.Parent.Cedente.Agencia = rAgencia;
            Banco.Parent.Cedente.AgenciaDigito = string.Empty;
            Banco.Parent.Cedente.Conta = rConta;
            Banco.Parent.Cedente.ContaDigito = string.Empty;
            
            Banco.Parent.ListadeBoletos.Clear();

            for (var i = 1; i < aRetorno.Count - 1; i++)
            {
                var linha = aRetorno[i];
                if (linha.ExtrairDaPosicao(1, 1) != "1")
                    continue;

                var titulo = Banco.Parent.CriarTituloNaLista();
                titulo.NossoNumero = linha.ExtrairDaPosicao(63, 72);
                titulo.SeuNumero = linha.ExtrairDaPosicao(117, 126);
                titulo.NumeroDocumento = linha.ExtrairDaPosicao( 117, 126);

                titulo.ValorDocumento = linha.ExtrairDecimalDaPosicao(153, 165);
                titulo.ValorAbatimento = linha.ExtrairDecimalDaPosicao(228, 240);
                titulo.ValorDesconto = linha.ExtrairDecimalDaPosicao(241, 253);
                titulo.ValorRecebido = linha.ExtrairDecimalDaPosicao(254, 266);
                titulo.ValorMoraJuros = linha.ExtrairDecimalDaPosicao(267, 279);
                titulo.ValorOutrosCreditos = linha.ExtrairDecimalDaPosicao(280, 292);    //Multa estava faltando
                //Anderson
                titulo.ValorDespesaCobranca = linha.ExtrairDecimalDaPosicao(176, 188);
                titulo.ValorOutrasDespesas = linha.ExtrairDecimalDaPosicao(189, 201);

                var tempvenc = linha.ExtrairDataOpcionalDaPosicao(247, 252);
                if (tempvenc.HasValue)
                    titulo.Vencimento = tempvenc.Value;

                var tempcredt = linha.ExtrairDataOpcionalDaPosicao(296, 301);
                if (tempcredt.HasValue)
                    titulo.DataCredito = tempcredt.Value;

                titulo.DataOcorrencia = linha.ExtrairDataDaPosicao(111, 116);

                var codOcorrencia = linha.ExtrairInt32DaPosicao(109, 110);
                titulo.OcorrenciaOriginal.Tipo = CodOcorrenciaToTipo(codOcorrencia);
              
                if(codOcorrencia == 3 || codOcorrencia == 16 || codOcorrencia == 18)
                {
                    titulo.DescricaoMotivoRejeicaoComando.Add(CodMotivoRejeicaoToDescricao(titulo.OcorrenciaOriginal.Tipo, "0"));
                    var idxMotivo = 383;
                    while (idxMotivo < 392)
                    {
                        if (linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1) != "  ")
                        {
                            titulo.MotivoRejeicaoComando.Add(linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1));
                            titulo.DescricaoMotivoRejeicaoComando.Add(CodMotivoRejeicaoToDescricao(titulo.OcorrenciaOriginal.Tipo,
                            linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1)));
                        }
                        
                        idxMotivo += 2;
                    }
                }
            }
        }

        /// <summary>
        /// Gerars the registro header240.
        /// </summary>
        /// <param name="numeroRemessa">The numero remessa.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override string GerarRegistroHeader240(int numeroRemessa)
        {
            string tipoInsc;
            switch(Banco.Parent.Cedente.TipoInscricao)
            {
                case PessoaCedente.Fisica: tipoInsc = "1"; break;
                case PessoaCedente.Juridica: tipoInsc = "2"; break;
                default: tipoInsc = "9"; break;
            }

            var wLinha = new StringBuilder();
            wLinha.Append("041");                                                             //   1 -   3   C�digo do banco
            wLinha.Append("".ZeroFill(4));                                                    //   4 -   7   Lote de servi�o
            wLinha.Append('0');                                                               //   8 -   8   Registro header de arquivo
            wLinha.Append("".FillRight(9));                                                    //   9 -  17   Uso exclusivo FEBRABAN/CNAB
            wLinha.Append(tipoInsc);                                                          //  18 -  18   Tipo de inscri��o
            wLinha.Append(Banco.Parent.Cedente.CNPJCPF.OnlyNumbers().ZeroFill(14));           //  19 -  32   N�mero de inscri��o da empresa (N�o considerado)
            wLinha.Append(Banco.Parent.Cedente.Convenio.OnlyNumbers().FillRight(13, '0'));     //  33 -  45   C�digo do conv�nio
            wLinha.Append("".FillRight(7));                                                    //  46 -  52   Brancos
            wLinha.Append("00");                                                              //  53 -  54   Zeros
            wLinha.Append(Banco.Parent.Cedente.Agencia.OnlyNumbers().FillRight(3, '0'));       //  55 -  57   Ag�ncia (N�o considerado)
            wLinha.Append(Banco.Parent.Cedente.AgenciaDigito.OnlyNumbers().FillRight(1, '0')); //  58 -  58   D�gito ag�ncia (N�o considerado)
            wLinha.Append(Banco.Parent.Cedente.Conta.OnlyNumbers().FillRight(12, '0'));        //  59 -  70   N�mero da conta (N�o considerado)
            wLinha.Append(Banco.Parent.Cedente.ContaDigito.OnlyNumbers().FillRight(1, '0'));   //  71 -  71   D�gito da conta (N�o considerado)
            wLinha.Append("".FillRight(1));                                                    //  72 -  72   D�gito verificador da ag�ncia/conta (N�o considerado)
            wLinha.Append(Banco.Parent.Cedente.Nome.FillLeft(30));                             //  73 - 102   Nome do cedente
            wLinha.Append(Banco.Parent.Banco.Nome.FillLeft(30).ToUpper());                     // 103 - 132   Nome do banco
            wLinha.Append("".FillRight(10));                                                   // 133 - 142   Uso exclusivo FEBRABAN/CNAB
            wLinha.Append('1');                                                               // 143 - 143   C�digo remessa
            wLinha.AppendFormat("{0:ddMMyyyyhhmmss}", DateTime.Now);                          // 144 - 157   Data e hora da gera��o do arquivo
            wLinha.AppendFormat("{0:000000}", numeroRemessa);                                 // 158 - 163   N�mero sequencial do arquivo
            wLinha.Append("040");                                                             // 164 - 166   N�mero da vers�o do layout do arquivo
            wLinha.Append("".ZeroFill(5));                                                    // 167 - 171   Densidade de grava��o do arquivo
            wLinha.Append("".FillRight(60));                                                   // 172 - 240   Outros campos  

            wLinha.Append(Environment.NewLine);
            wLinha.Append("041");                                                             //   1 -   3   C�digo do banco
            wLinha.Append("0001");                                                            //   4 -   7   Lote de servi�o
            wLinha.Append('1');                                                               //   8 -   8   Registro header de lote
            wLinha.Append('R');                                                               //   9 -   9   Tipo de opera��o
            wLinha.Append("01");                                                              //  10 -  11   Tipo de servi�o
            wLinha.Append("00");                                                              //  12 -  13   Forma de lan�amento
            wLinha.Append("020");                                                             //  14 -  16   N�mero da vers�o do layout do lote
            wLinha.Append("".FillRight(1));                                                    //  17 -  17   Uso exclusivo FEBRABAN/CNAB
            wLinha.Append(tipoInsc);                                                          //  18 -  18   Tipo de inscri��o da empresa
            wLinha.Append(Banco.Parent.Cedente.CNPJCPF.OnlyNumbers().ZeroFill(15));           //  19 -  33   N�mero de inscri��o da empresa
            wLinha.Append(Banco.Parent.Cedente.Convenio.OnlyNumbers().FillRight(13, '0'));     //  34 -  46   C�digo do conv�nio
            wLinha.Append("".FillRight(7));                                                    //  47 -  53   Brancos
            wLinha.Append(Banco.Parent.Cedente.Agencia.OnlyNumbers().FillRight(5, '0'));       //  54 -  58   Ag�ncia
            wLinha.Append(Banco.Parent.Cedente.AgenciaDigito.OnlyNumbers().FillRight(1, '0')); //  59 -  59   D�gito da ag�ncia
            wLinha.Append(Banco.Parent.Cedente.Conta.OnlyNumbers().FillRight(12, '0'));        //  60 -  71   N�mero da conta
            wLinha.Append(Banco.Parent.Cedente.ContaDigito.OnlyNumbers().FillRight(1, '0'));   //  72 -  72   D�gito da conta
            wLinha.Append("".FillRight(1));                                                    //  73 -  73   D�gito verificador da ag�ncia/conta
            wLinha.Append(Banco.Parent.Cedente.Nome.FillLeft(30));                             //  74 - 103   Nome da empresa
            wLinha.Append("".FillRight(80));                                                   // 104 - 183   Mensagens
            wLinha.AppendFormat("{0:00000000}", numeroRemessa);                               // 184 - 191   N�mero sequencial do arquivo
            wLinha.AppendFormat("{0:ddMMyyyy}", DateTime.Now);                                // 192 - 199   Data de gera��o do arquivo
            wLinha.Append("".ZeroFill(8));                                                    // 200 - 207   Data do cr�dito
            wLinha.Append("".FillRight(33));                                                   // 208 - 240   Uso exclusivo FEBRABAN/CNAB

            return wLinha.ToString();
        }

        /// <summary>
        /// Gerars the registro transacao240.
        /// </summary>
        /// <param name="titulo">The titulo.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override string GerarRegistroTransacao240(Titulo titulo)
        {
            string aAceite;
            switch(titulo.Aceite)
            {
                case AceiteTitulo.Sim: aAceite = "S"; break;
                default: aAceite = "N"; break;
            }

            var diasProt = "00";
            if (titulo.DataProtesto.HasValue && titulo.DataProtesto > titulo.Vencimento)
                diasProt = string.Format("{0:00}", (titulo.DataProtesto.Value - titulo.Vencimento).TotalDays);

            if (diasProt == "00")
                diasProt = string.Format("0{0}", diasProt);
            else
                diasProt = string.Format("1{0}", diasProt);

            string juros;
            if (titulo.DataMoraJuros.HasValue)
                juros = string.Format("1{0:ddMMyyyy}{1}", titulo.DataMoraJuros, titulo.ValorMoraJuros.ToDecimalString(15));
            else
               juros = "".ZeroFill(24);

            string tipoInscSacado;
            switch(titulo.Sacado.Pessoa)
            {
                case Pessoa.Fisica: tipoInscSacado = "1"; break;
                case Pessoa.Juridica: tipoInscSacado = "2"; break;
                default: tipoInscSacado = "1"; break;
            }

            string ocorrencia;
            switch(titulo.OcorrenciaOriginal.Tipo)
            {
                case TipoOcorrencia.RemessaBaixar: ocorrencia = "02"; break; //Pedido de Baixa
                case TipoOcorrencia.RemessaConcederAbatimento: ocorrencia = "04"; break; //Concess�o de Abatimento
                case TipoOcorrencia.RemessaCancelarAbatimento: ocorrencia = "05"; break; //Cancelamento de Abatimento concedido
                case TipoOcorrencia.RemessaAlterarVencimento: ocorrencia = "06"; break; //Altera��o de vencimento
                case TipoOcorrencia.RemessaProtestar: ocorrencia = "09"; break; //Pedido de protesto
                case TipoOcorrencia.RemessaCancelarInstrucaoProtestoBaixa: ocorrencia = "18"; break; //Sustar protesto e baixar
                case TipoOcorrencia.RemessaCancelarInstrucaoProtesto: ocorrencia = "19"; break; //Sustar protesto e manter na carteira
                case TipoOcorrencia.RemessaOutrasOcorrencias: ocorrencia = "31"; break; //Altera��o de Outros Dados
                default: ocorrencia = "1"; break;
            }
            
            var wLinha = new StringBuilder();
            wLinha.Append("04100013");
            wLinha.Append("".FillRight(5, '*'));
            wLinha.Append("P ");
            wLinha.Append(ocorrencia);
            wLinha.Append("".FillRight(20));
            wLinha.Append(MontarCampoNossoNumero(titulo).OnlyNumbers().FillRight(10, '0'));
            wLinha.Append("".FillRight(10));
            wLinha.Append(titulo.Carteira);
            wLinha.Append("1020");
            wLinha.Append(titulo.NumeroDocumento.FillLeft(15));
            wLinha.AppendFormat("{0:ddMMyyyy}", titulo.Vencimento);
            wLinha.Append(titulo.ValorDocumento.ToDecimalString(15));
            wLinha.Append("00000002");
            wLinha.Append(aAceite);
            wLinha.AppendFormat("{0:ddMMyyyy}", titulo.DataProcessamento);
            wLinha.Append(juros);
            wLinha.Append("".ZeroFill(39));
            wLinha.Append("".FillRight(15));
            wLinha.Append(titulo.NumeroDocumento.FillLeft(15));
            wLinha.Append("".FillRight(10));
            wLinha.Append(diasProt);
            wLinha.Append(string.IsNullOrEmpty(titulo.Instrucao1.Trim()) ? "1" : titulo.Instrucao1);
            wLinha.Append(titulo.Instrucao2.FillRight(3, '0'));
            wLinha.Append("09");
            wLinha.Append("".ZeroFill(10));
            wLinha.Append(' ');

            wLinha.Append(Environment.NewLine);
            wLinha.Append("04100013");
            wLinha.Append("".FillRight(5, '*'));
            wLinha.Append("Q ");
            wLinha.Append(ocorrencia);
            wLinha.Append(tipoInscSacado);
            wLinha.Append(titulo.Sacado.CNPJCPF.OnlyNumbers().FillRight(15, '0'));
            wLinha.Append(titulo.Sacado.NomeSacado.FillLeft(40));
            wLinha.Append(titulo.Sacado.Logradouro.FillLeft(40));
            wLinha.Append(titulo.Sacado.Bairro.FillLeft(15));
            wLinha.Append(titulo.Sacado.CEP.OnlyNumbers().ZeroFill(8));
            wLinha.Append(titulo.Sacado.Cidade.FillLeft(15));
            wLinha.Append(titulo.Sacado.UF.FillLeft(2));
            wLinha.Append("".ZeroFill(16));
            wLinha.Append("".FillRight(40));
            wLinha.Append("000");
            wLinha.Append("".FillRight(28));

            wLinha.Append(Environment.NewLine);
            wLinha.Append("04100013");
            wLinha.Append("".FillRight(5, '*'));
            wLinha.Append("R ");
            wLinha.Append(ocorrencia);
            wLinha.Append("".FillRight(48));
            wLinha.Append('1');
            wLinha.AppendFormat("{0:ddMMyyyy}", titulo.Vencimento);
            wLinha.Append((titulo.PercentualMulta * titulo.ValorDocumento).ToDecimalString(15));
            wLinha.Append("".ZeroFill(90));
            wLinha.Append("".FillRight(28));
            wLinha.Append("".ZeroFill(33));

            return wLinha.ToString();
        }

        /// <summary>
        /// Gerars the registro trailler240.
        /// </summary>
        /// <param name="aRemessa">A remessa.</param>
        /// <returns>System.String.</returns>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override string GerarRegistroTrailler240(List<string> aRemessa)
        {
            decimal valor = 0;
            var ps = 1;
            for(var i = 0; i < aRemessa.Count; i++)
            {
                if (aRemessa[i][14] == 'P')
                    valor += aRemessa[i].ExtrairDecimalDaPosicao(86, 100);

                if(aRemessa[i].ExtrairDaPosicao(7, 11) == "*****")
                    aRemessa[i].Replace("*****", string.Format("{0:00000}", ps));

                ps++;
            }

            var wLinha = new StringBuilder();
            wLinha.Append("04100015");
            wLinha.Append("".FillRight(9));
            wLinha.AppendFormat("{0:000000}", aRemessa.Count * 2);
            wLinha.AppendFormat("{0:000000}", ((aRemessa.Count * 2) - 2) % 2);
            wLinha.Append(valor.ToDecimalString(17));
            wLinha.Append("".FillRight(77, '0'));
            wLinha.Append("".FillRight(117));

            wLinha.Append(Environment.NewLine);
            wLinha.Append("04199999");
            wLinha.Append("".FillRight(9));
            wLinha.Append("000001");
            wLinha.AppendFormat("{0:000000}", (aRemessa.Count + 1) * 2);
            wLinha.Append("".FillRight(6, '0'));
            wLinha.Append("".FillRight(205));

            return wLinha.ToString();
        }

        /// <summary>
        /// Lers the retorno240.
        /// </summary>
        /// <param name="aRetorno">A retorno.</param>
        /// <exception cref="ACBrException">
        /// @CNPJ\CPF do arquivo inv�lido
        /// or
        /// @Agencia\Conta do arquivo inv�lido
        /// </exception>
        /// <exception cref="System.NotImplementedException">Esta fun��o n�o esta implementada para este banco</exception>
        public override void LerRetorno240(List<string> aRetorno)
        {
            Guard.Against<ACBrException>(aRetorno[0].ExtrairInt32DaPosicao(1, 3) != Numero,
                "{0} n�o � um arquivo de retorno do {1}'", Banco.Parent.NomeArqRetorno, Nome);

            var rCedente = aRetorno[0].ExtrairDaPosicao(73, 102).Trim();
            var rConvenio = aRetorno[1].ExtrairDaPosicao(34, 36);
            var rAgencia = aRetorno[1].ExtrairDaPosicao(54, 58);
            var rAgenciaDigito = aRetorno[1].ExtrairDaPosicao(59, 59);
            var rConta = aRetorno[1].ExtrairDaPosicao(60, 71);
            var rContaDigito = aRetorno[1].ExtrairDaPosicao(72, 72); 

            Banco.Parent.NumeroArquivo = aRetorno[0].ExtrairInt32DaPosicao(158, 163);
            Banco.Parent.DataArquivo = aRetorno[0].ExtrairDataDaPosicao(144, 151);
            Banco.Parent.DataCreditoLanc = aRetorno[1].ExtrairDataDaPosicao(200, 207);

            var rCNPJCPF = aRetorno[1].ExtrairDaPosicao(19, 32).OnlyNumbers();
            Guard.Against<ACBrException>(
				!Banco.Parent.LeCedenteRetorno && rCNPJCPF != Banco.Parent.Cedente.CNPJCPF.OnlyNumbers(),
                @"CNPJ\CPF do arquivo inv�lido");

            Guard.Against<ACBrException>(
				!Banco.Parent.LeCedenteRetorno && (rAgencia != Banco.Parent.Cedente.Agencia.OnlyNumbers() ||
                rConta != Banco.Parent.Cedente.Conta.OnlyNumbers()),
                @"Agencia\Conta do arquivo inv�lido");

            Banco.Parent.Cedente.Nome = rCedente;
            Banco.Parent.Cedente.CNPJCPF = rCNPJCPF;
            Banco.Parent.Cedente.Convenio = rConvenio;
            Banco.Parent.Cedente.Agencia = rAgencia;
            Banco.Parent.Cedente.AgenciaDigito = rAgenciaDigito;
            Banco.Parent.Cedente.Conta = rConta;
            Banco.Parent.Cedente.ContaDigito = rContaDigito; 

            switch (aRetorno[0].ExtrairInt32DaPosicao(18, 18))
            {
                case 1:
                    Banco.Parent.Cedente.TipoInscricao = PessoaCedente.Fisica;
                    break;

                default:
                    Banco.Parent.Cedente.TipoInscricao = PessoaCedente.Juridica;
                    break;
            }

            Banco.Parent.ListadeBoletos.Clear();

            Titulo titulo = null;
            for (var contLinha = 1; contLinha < aRetorno.Count - 1; contLinha++)
            {
                var linha = aRetorno[contLinha];

                // verifica se o registro (linha) � um registro detalhe (segmento J)
                if (linha.ExtrairInt32DaPosicao(8, 8) != 3)
                    continue;

                if (linha.ExtrairDaPosicao(14, 14) == "T")
                {
                    titulo = Banco.Parent.CriarTituloNaLista();

                    if (linha.ExtrairDaPosicao(133, 133) == "1")
                        titulo.Sacado.Pessoa = Pessoa.Fisica;
                    else if (linha.ExtrairDaPosicao(133, 133) == "2")
                        titulo.Sacado.Pessoa = Pessoa.Juridica;
                    else
                        titulo.Sacado.Pessoa = Pessoa.Outras;
                    
                    switch(titulo.Sacado.Pessoa)
                    {
                        case Pessoa.Fisica: 
                            titulo.Sacado.CNPJCPF = linha.ExtrairDaPosicao(137, 148);
                            break;

                        case Pessoa.Juridica: 
                            titulo.Sacado.CNPJCPF = linha.ExtrairDaPosicao(135, 148);
                            break;

                        default:
                            titulo.Sacado.CNPJCPF = linha.ExtrairDaPosicao(134, 148);
                            break;
                    }

                    titulo.Sacado.NomeSacado = linha.ExtrairDaPosicao(149, 188).Trim();

                    titulo.SeuNumero = linha.ExtrairDaPosicao(106, 130);
                    titulo.NumeroDocumento = linha.ExtrairDaPosicao(59, 73);
                    titulo.Carteira = linha.ExtrairDaPosicao(58, 58);

                    var dt = linha.ExtrairDataOpcionalDaPosicao(74, 81);
                    if (dt.HasValue)
                        titulo.Vencimento = dt.Value;

                    titulo.ValorDocumento = linha.ExtrairDecimalDaPosicao(82, 96);
                    titulo.NossoNumero = linha.ExtrairDaPosicao(38, 57);
                    titulo.ValorDespesaCobranca = linha.ExtrairDecimalDaPosicao(199, 213);
                    titulo.OcorrenciaOriginal.Tipo = CodOcorrenciaToTipo(linha.ExtrairInt32DaPosicao(16, 17));

                    var idxMotivo = 214;
                    while (idxMotivo < 223)
                    {
                        if (string.IsNullOrEmpty(linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1)))
                        {
                            titulo.MotivoRejeicaoComando.Add(linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1));
                            titulo.DescricaoMotivoRejeicaoComando.Add(
                                CodMotivoRejeicaoToDescricao(titulo.OcorrenciaOriginal.Tipo,
                                linha.ExtrairDaPosicao(idxMotivo, idxMotivo + 1)));
                        }
                        idxMotivo += 2;
                    }
                }

                if (linha.ExtrairDaPosicao(14, 14) == "U")
                {
                    // segmento U
                    titulo.ValorIOF = linha.ExtrairDecimalDaPosicao(63, 77);
                    titulo.ValorAbatimento = linha.ExtrairDecimalDaPosicao(48, 62);
                    titulo.ValorDesconto = linha.ExtrairDecimalDaPosicao(33, 47);
                    titulo.ValorMoraJuros = linha.ExtrairDecimalDaPosicao(18, 32);
                    titulo.ValorOutrosCreditos = linha.ExtrairDecimalDaPosicao(123, 137);
                    titulo.ValorRecebido = linha.ExtrairDecimalDaPosicao(78, 92);
                    titulo.ValorOutrasDespesas = linha.ExtrairDecimalDaPosicao(108, 113); 

                    var tempData = linha.ExtrairDataOpcionalDaPosicao(138, 145);
                    if (tempData.HasValue)
                        titulo.DataOcorrencia = tempData.Value;

                    tempData = linha.ExtrairDataOpcionalDaPosicao(146, 153);
                    if (tempData.HasValue)
                        titulo.DataCredito = tempData.Value;
                }
            }
        }

        #endregion Methods
    }
}
