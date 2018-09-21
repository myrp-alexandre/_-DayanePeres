/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v6.1.3                     */
/* Target DBMS:           PostgreSQL 8.3                                  */
/* Project file:          Modelagem_HL_Correcao_ATUALIZADO.dez            */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database drop script                            */
/* Created on:            2018-09-21 13:32                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Drop foreign key constraints                                           */
/* ---------------------------------------------------------------------- */

ALTER TABLE TBCIDADE DROP CONSTRAINT TBESTADO_TBCIDADE;

ALTER TABLE TBENDERECO DROP CONSTRAINT TBCIDADE_TBENDERECO;

ALTER TABLE TBENDERECO DROP CONSTRAINT TBPESSOA_TBENDERECO;

ALTER TABLE TBCONTATO DROP CONSTRAINT TBPESSOA_TBCONTATO;

ALTER TABLE TBFISICA DROP CONSTRAINT TBPESSOA_TBFISICA;

ALTER TABLE TBJURIDICA DROP CONSTRAINT TBPESSOA_TBJURIDICA;

ALTER TABLE TBUSUARIO DROP CONSTRAINT TBPESSOA_TBUSUARIO;

ALTER TABLE TBCOMPRA DROP CONSTRAINT TBDESPESA_TBCOMPRA;

ALTER TABLE TBCOMPRA DROP CONSTRAINT TBJURIDICA_TBCOMPRA;

ALTER TABLE TBAGENDA DROP CONSTRAINT TBPESSOA_TBAGENDA;

ALTER TABLE TBAGENDA DROP CONSTRAINT TBCOMISSAO_TBAGENDA;

ALTER TABLE TBAGENDA DROP CONSTRAINT TBCONTRATO_TBAGENDA;

ALTER TABLE TBPRODUTO DROP CONSTRAINT TBCATEGORIA_TBPRODUTO;

ALTER TABLE TBPRODUTO DROP CONSTRAINT TBMARCA_TBPRODUTO;

ALTER TABLE TBBAIXA DROP CONSTRAINT TBPRODUTO_TBBAIXA;

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT TBCOMPRA_TBCONTASPAGAR;

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT TBDESPESA_TBCONTASPAGAR;

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT TBCAIXA_TBCONTASPAGAR;

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT TBFORMAPAGAMENTO_TBCONTASPAGAR;

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT TBCOMISSAO_TBCONTASPAGAR;

ALTER TABLE TBCONTRATO DROP CONSTRAINT TBPACOTE_TBCONTRATO;

ALTER TABLE TBCONTRATO DROP CONSTRAINT TBFISICA_TBCONTRATO;

ALTER TABLE TBPACOTESADICIONAIS DROP CONSTRAINT TBTIPOSERVICO_TBPACOTESADICIONAIS;

ALTER TABLE TBPACOTESADICIONAIS DROP CONSTRAINT TBCONTRATO_TBPACOTESADICIONAIS;

ALTER TABLE TBPACOTESERVICO DROP CONSTRAINT TBPACOTE_TBPACOTESERVICO;

ALTER TABLE TBPACOTESERVICO DROP CONSTRAINT TBTIPOSERVICO_TBPACOTESERVICO;

ALTER TABLE TBVENDA DROP CONSTRAINT TBPESSOA_TBVENDA;

ALTER TABLE TBVENDAPRODUTO DROP CONSTRAINT TBVENDA_TBVENDAPRODUTO;

ALTER TABLE TBVENDAPRODUTO DROP CONSTRAINT TBPRODUTO_TBVENDAPRODUTO;

ALTER TABLE TBCOMPRAPRODUTO DROP CONSTRAINT TBCOMPRA_TBCOMPRAPRODUTO;

ALTER TABLE TBCOMPRAPRODUTO DROP CONSTRAINT TBPRODUTO_TBCOMPRAPRODUTO;

ALTER TABLE TBCOMPRAPRODUTO DROP CONSTRAINT TBCOMPRAPRODUTO_TBCOMPRAPRODUTO;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBCONTRATO_TBCONTASRECEBER;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBVENDA_TBCONTASRECEBER;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBCOMISSAO_TBCONTASRECEBER;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBCAIXA_TBCONTASRECEBER;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBFORMAPAGAMENTO_TBCONTASRECEBER;

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT TBFIADO_TBCONTASRECEBER;

ALTER TABLE TBCAIXA DROP CONSTRAINT TBUSUARIO_TBCAIXA;

ALTER TABLE TBPRESTADORSERVICO DROP CONSTRAINT TBJURIDICA_TBPRESTADORSERVICO;

ALTER TABLE TBPRESTADORSERVICO DROP CONSTRAINT TBTIPOSERVICO_TBPRESTADORSERVICO;

ALTER TABLE TBFIADO DROP CONSTRAINT TBPESSOA_TBFIADO;

ALTER TABLE TBFIADO DROP CONSTRAINT TBAGENDA_TBFIADO;

ALTER TABLE TBFIADO DROP CONSTRAINT TBVENDA_TBFIADO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCOMPRAPRODUTO"                                           */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCOMPRAPRODUTO DROP CONSTRAINT PK_TBCOMPRAPRODUTO;

/* Drop table */

DROP TABLE TBCOMPRAPRODUTO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCONTASRECEBER"                                           */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCONTASRECEBER DROP CONSTRAINT PK_TBCONTASRECEBER;

/* Drop table */

DROP TABLE TBCONTASRECEBER;

/* ---------------------------------------------------------------------- */
/* Drop table "TBFIADO"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBFIADO DROP CONSTRAINT PK_TBFIADO;

/* Drop table */

DROP TABLE TBFIADO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBAGENDA"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBAGENDA DROP CONSTRAINT PK_TBAGENDA;

/* Drop table */

DROP TABLE TBAGENDA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBVENDAPRODUTO"                                            */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBVENDAPRODUTO DROP CONSTRAINT PK_TBVENDAPRODUTO;

/* Drop table */

DROP TABLE TBVENDAPRODUTO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPACOTESADICIONAIS"                                       */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPACOTESADICIONAIS DROP CONSTRAINT PK_TBPACOTESADICIONAIS;

/* Drop table */

DROP TABLE TBPACOTESADICIONAIS;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCONTRATO"                                                */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCONTRATO DROP CONSTRAINT PK_TBCONTRATO;

/* Drop table */

DROP TABLE TBCONTRATO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCONTASPAGAR"                                             */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCONTASPAGAR DROP CONSTRAINT PK_TBCONTASPAGAR;

/* Drop table */

DROP TABLE TBCONTASPAGAR;

/* ---------------------------------------------------------------------- */
/* Drop table "TBBAIXA"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBBAIXA DROP CONSTRAINT PK_TBBAIXA;

/* Drop table */

DROP TABLE TBBAIXA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPRODUTO"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPRODUTO DROP CONSTRAINT PK_TBPRODUTO;

/* Drop table */

DROP TABLE TBPRODUTO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBENDERECO"                                                */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBENDERECO DROP CONSTRAINT PK_TBENDERECO;

/* Drop table */

DROP TABLE TBENDERECO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPRESTADORSERVICO"                                        */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPRESTADORSERVICO DROP CONSTRAINT PK_TBPRESTADORSERVICO;

/* Drop table */

DROP TABLE TBPRESTADORSERVICO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBFORMAPAGAMENTO"                                          */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBFORMAPAGAMENTO DROP CONSTRAINT PK_TBFORMAPAGAMENTO;

/* Drop table */

DROP TABLE TBFORMAPAGAMENTO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPARAMETRO"                                               */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPARAMETRO DROP CONSTRAINT PK_TBPARAMETRO;

/* Drop table */

DROP TABLE TBPARAMETRO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCAIXA"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCAIXA DROP CONSTRAINT PK_TBCAIXA;

/* Drop table */

DROP TABLE TBCAIXA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBVENDA"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBVENDA DROP CONSTRAINT PK_TBVENDA;

/* Drop table */

DROP TABLE TBVENDA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPACOTESERVICO"                                           */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPACOTESERVICO DROP CONSTRAINT PK_TBPACOTESERVICO;

/* Drop table */

DROP TABLE TBPACOTESERVICO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPACOTE"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPACOTE DROP CONSTRAINT PK_TBPACOTE;

/* Drop table */

DROP TABLE TBPACOTE;

/* ---------------------------------------------------------------------- */
/* Drop table "TBMARCA"                                                   */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBMARCA DROP CONSTRAINT PK_TBMARCA;

/* Drop table */

DROP TABLE TBMARCA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCATEGORIA"                                               */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCATEGORIA DROP CONSTRAINT PK_TBCATEGORIA;

/* Drop table */

DROP TABLE TBCATEGORIA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCOMISSAO"                                                */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCOMISSAO DROP CONSTRAINT PK_TBCOMISSAO;

/* Drop table */

DROP TABLE TBCOMISSAO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBTIPOSERVICO"                                             */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBTIPOSERVICO DROP CONSTRAINT PK_TBTIPOSERVICO;

/* Drop table */

DROP TABLE TBTIPOSERVICO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCOMPRA"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCOMPRA DROP CONSTRAINT PK_TBCOMPRA;

/* Drop table */

DROP TABLE TBCOMPRA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBDESPESA"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBDESPESA DROP CONSTRAINT PK_TBDESPESA;

/* Drop table */

DROP TABLE TBDESPESA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBUSUARIO"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBUSUARIO DROP CONSTRAINT PK_TBUSUARIO;

/* Drop table */

DROP TABLE TBUSUARIO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBJURIDICA"                                                */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBJURIDICA DROP CONSTRAINT PK_TBJURIDICA;

/* Drop table */

DROP TABLE TBJURIDICA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBFISICA"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBFISICA DROP CONSTRAINT PK_TBFISICA;

/* Drop table */

DROP TABLE TBFISICA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCONTATO"                                                 */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCONTATO DROP CONSTRAINT PK_TBCONTATO;

/* Drop table */

DROP TABLE TBCONTATO;

/* ---------------------------------------------------------------------- */
/* Drop table "TBPESSOA"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBPESSOA DROP CONSTRAINT PK_TBPESSOA;

/* Drop table */

DROP TABLE TBPESSOA;

/* ---------------------------------------------------------------------- */
/* Drop table "TBCIDADE"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBCIDADE DROP CONSTRAINT PK_TBCIDADE;

/* Drop table */

DROP TABLE TBCIDADE;

/* ---------------------------------------------------------------------- */
/* Drop table "TBESTADO"                                                  */
/* ---------------------------------------------------------------------- */

/* Drop constraints */

ALTER TABLE TBESTADO DROP CONSTRAINT PK_TBESTADO;

/* Drop table */

DROP TABLE TBESTADO;
