/* ---------------------------------------------------------------------- */
/* Script generated with: DeZign for Databases v6.1.3                     */
/* Target DBMS:           PostgreSQL 8.3                                  */
/* Project file:          Modelagem_HL_Correcao_ATUALIZADO.dez            */
/* Project name:                                                          */
/* Author:                                                                */
/* Script type:           Database creation script                        */
/* Created on:            2018-09-21 13:32                                */
/* ---------------------------------------------------------------------- */


/* ---------------------------------------------------------------------- */
/* Tables                                                                 */
/* ---------------------------------------------------------------------- */

/* ---------------------------------------------------------------------- */
/* Add table "TBESTADO"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBESTADO (
    codUf SERIAL  NOT NULL,
    uf CHARACTER VARYING(40),
    nome CHARACTER VARYING(100),
    CONSTRAINT PK_TBESTADO PRIMARY KEY (codUf)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCIDADE"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCIDADE (
    codCidade SERIAL  NOT NULL,
    nome CHARACTER VARYING(120),
    codUf INTEGER  NOT NULL,
    CONSTRAINT PK_TBCIDADE PRIMARY KEY (codCidade, codUf)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBENDERECO"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBENDERECO (
    codEndereco SERIAL  NOT NULL,
    end_cep CHARACTER VARYING(40),
    end_logradouro CHARACTER VARYING(100),
    end_numero CHARACTER VARYING(100),
    end_bairro CHARACTER VARYING(100),
    edn_complemento CHARACTER VARYING(100),
    codCidade INTEGER  NOT NULL,
    codUf INTEGER  NOT NULL,
    codPessoa INTEGER,
    CONSTRAINT PK_TBENDERECO PRIMARY KEY (codEndereco, codCidade, codUf)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPESSOA"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPESSOA (
    codPessoa SERIAL  NOT NULL,
    pes_nome CHARACTER VARYING(100),
    pes_dataCadastro DATE,
    pes_tipoPessoa CHARACTER VARYING(10),
    pes_statusPessoa BOOLEAN,
    pes_obs CHARACTER VARYING(400),
    pes_fiado BOOLEAN,
    pes_email CHARACTER VARYING(100),
    CONSTRAINT PK_TBPESSOA PRIMARY KEY (codPessoa)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCONTATO"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCONTATO (
    codContato SERIAL  NOT NULL,
    cont_telefone CHARACTER VARYING(40),
    cont_tipoFone CHARACTER VARYING(2),
    codPessoa INTEGER,
    CONSTRAINT PK_TBCONTATO PRIMARY KEY (codContato)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBFISICA"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBFISICA (
    codPessoa INTEGER  NOT NULL,
    fis_cpf CHARACTER VARYING(12)  NOT NULL,
    fis_rg CHARACTER VARYING(40),
    fis_dataNascimento DATE,
    CONSTRAINT PK_TBFISICA PRIMARY KEY (fis_cpf)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBJURIDICA"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBJURIDICA (
    codPessoa INTEGER  NOT NULL,
    jur_cnpj CHARACTER VARYING(40)  NOT NULL,
    jur_razaoSocial CHARACTER VARYING(100),
    jur_fantasia CHARACTER VARYING(100),
    CONSTRAINT PK_TBJURIDICA PRIMARY KEY (jur_cnpj)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBUSUARIO"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBUSUARIO (
    codUsuario SERIAL  NOT NULL,
    codPessoa INTEGER  NOT NULL,
    codUsuarioLog INTEGER,
    usu_usuario CHARACTER VARYING(50),
    usu_senha CHARACTER VARYING(40),
    usu_nivel INTEGER,
    CONSTRAINT PK_TBUSUARIO PRIMARY KEY (codUsuario, codPessoa)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBDESPESA"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBDESPESA (
    codDespesa SERIAL  NOT NULL,
    desp_descricao CHARACTER VARYING(100),
    desp_status CHARACTER(40),
    CONSTRAINT PK_TBDESPESA PRIMARY KEY (codDespesa)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCOMPRA"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCOMPRA (
    codCompra SERIAL  NOT NULL,
    codDespesa INTEGER,
    comp_dataCompra DATE,
    comp_situacao CHARACTER VARYING(40),
    comp_statusConsignado BOOLEAN,
    comp_valorTotal NUMERIC(10,2),
    comp_obs CHARACTER VARYING(300),
    codPessoa INTEGER,
    jur_cnpj CHARACTER VARYING(40),
    CONSTRAINT PK_TBCOMPRA PRIMARY KEY (codCompra)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBAGENDA"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBAGENDA (
    codAgenda SERIAL  NOT NULL,
    codPessoa INTEGER  NOT NULL,
    agen_dataAgendamento DATE  NOT NULL,
    agen_horaAgendamento DATE  NOT NULL,
    agen_status CHARACTER VARYING(40),
    agen_valor NUMERIC(10,2),
    codComissao INTEGER  NOT NULL,
    codContrato INTEGER,
    CONSTRAINT PK_TBAGENDA PRIMARY KEY (codAgenda)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBTIPOSERVICO"                                              */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBTIPOSERVICO (
    codTipoServico SERIAL  NOT NULL,
    tipoServ_descricao CHARACTER VARYING(100),
    tipoServ_obs CHARACTER VARYING(300),
    tipoServ_valor NUMERIC(10,2),
    tipoServ_tempoServico TIME WITH TIME ZONE,
    CONSTRAINT PK_TBTIPOSERVICO PRIMARY KEY (codTipoServico)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCOMISSAO"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCOMISSAO (
    codComissao SERIAL  NOT NULL,
    comis_dataPagamento DATE,
    comis_valorTotal NUMERIC(10,2),
    comis_valorPago NUMERIC(10,2),
    comis_valorDevedor NUMERIC(10,2),
    comis_statusComissao CHARACTER VARYING(40),
    comis_statusPagamento CHARACTER VARYING(40),
    CONSTRAINT PK_TBCOMISSAO PRIMARY KEY (codComissao)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPRODUTO"                                                  */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPRODUTO (
    codProduto SERIAL  NOT NULL,
    prod_produto CHARACTER VARYING(100),
    prod_precoCusto NUMERIC(10,2),
    prod_precoVenda NUMERIC(10,2),
    prod_qtde INTEGER,
    prod_obs CHARACTER VARYING(300),
    codCategoria INTEGER  NOT NULL,
    codMarca INTEGER  NOT NULL,
    CONSTRAINT PK_TBPRODUTO PRIMARY KEY (codProduto)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCATEGORIA"                                                */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCATEGORIA (
    codCategoria SERIAL  NOT NULL,
    cat_categoria CHARACTER VARYING(100),
    cat_obscategoria CHARACTER VARYING(300),
    CONSTRAINT PK_TBCATEGORIA PRIMARY KEY (codCategoria)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBMARCA"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBMARCA (
    codMarca SERIAL  NOT NULL,
    marc_nome CHARACTER VARYING(100),
    CONSTRAINT PK_TBMARCA PRIMARY KEY (codMarca)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBBAIXA"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBBAIXA (
    codBaixa SERIAL  NOT NULL,
    baix_data DATE,
    baix_qtde INTEGER,
    baix_obs CHARACTER VARYING(300),
    codProduto INTEGER  NOT NULL,
    CONSTRAINT PK_TBBAIXA PRIMARY KEY (codBaixa)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCONTASPAGAR"                                              */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCONTASPAGAR (
    codContasPagar SERIAL  NOT NULL,
    contPag_dataVencimento DATE,
    contPag_dataPagamento DATE,
    contPag_ValorTotal NUMERIC(10,2),
    contPag_valorPago NUMERIC(10,2),
    contPag_obs CHARACTER VARYING(300),
    contPag_status BOOLEAN,
    contPag_numParc INTEGER,
    codCompra INTEGER  NOT NULL,
    codDespesa INTEGER,
    codCaixa INTEGER  NOT NULL,
    codFormaPag INTEGER,
    codComissao INTEGER,
    CONSTRAINT PK_TBCONTASPAGAR PRIMARY KEY (codContasPagar)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCONTRATO"                                                 */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCONTRATO (
    codContrato SERIAL  NOT NULL,
    contra_data DATE,
    contra_ob CHARACTER VARYING(300),
    codPacote INTEGER,
    fis_cpf CHARACTER VARYING(12)  NOT NULL,
    contra_valor NUMERIC(10,2),
    CONSTRAINT PK_TBCONTRATO PRIMARY KEY (codContrato)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPACOTESADICIONAIS"                                        */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPACOTESADICIONAIS (
    codContrato INTEGER  NOT NULL,
    codTipoServico INTEGER  NOT NULL,
    pacAdc_qtde NUMERIC(10,2),
    fis_cpf CHARACTER VARYING(12)  NOT NULL,
    pacAdc_valor NUMERIC(10,2),
    pacAdc_obs CHARACTER VARYING(40),
    pacAdc_realizado BOOLEAN,
    CONSTRAINT PK_TBPACOTESADICIONAIS PRIMARY KEY (codContrato, codTipoServico, fis_cpf)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPACOTE"                                                   */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPACOTE (
    codPacote SERIAL  NOT NULL,
    pac_pacote CHARACTER VARYING(100),
    pac_valor NUMERIC(10,2),
    pac_obs CHARACTER VARYING(300),
    pac_periodicidade CHARACTER VARYING(40),
    pac_dataInicio DATE,
    pac_dataFim DATE,
    CONSTRAINT PK_TBPACOTE PRIMARY KEY (codPacote)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPACOTESERVICO"                                            */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPACOTESERVICO (
    codPacote INTEGER  NOT NULL,
    codTipoServico INTEGER  NOT NULL,
    pacServ_qtde INTEGER,
    pacServ_periodicidade CHARACTER(40),
    pacServ_valor NUMERIC(10,2),
    CONSTRAINT PK_TBPACOTESERVICO PRIMARY KEY (codPacote, codTipoServico)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBVENDA"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBVENDA (
    codVenda SERIAL  NOT NULL,
    vend_dataVenda DATE,
    vend_situacao CHARACTER VARYING(100),
    vend_valorTotal NUMERIC(10,2),
    vend_obs CHARACTER VARYING(300),
    codPessoa INTEGER  NOT NULL,
    CONSTRAINT PK_TBVENDA PRIMARY KEY (codVenda)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBVENDAPRODUTO"                                             */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBVENDAPRODUTO (
    codVenda INTEGER  NOT NULL,
    codProduto INTEGER  NOT NULL,
    vendProd_qtde INTEGER,
    vendProd_valor NUMERIC(10,2),
    CONSTRAINT PK_TBVENDAPRODUTO PRIMARY KEY (codVenda, codProduto)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCOMPRAPRODUTO"                                            */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCOMPRAPRODUTO (
    codCompra INTEGER  NOT NULL,
    codProduto INTEGER  NOT NULL,
    compProd_qtde INTEGER,
    compProd_valor NUMERIC(10,2),
    compProd_qtdeDevolvida NUMERIC,
    codCompra1 INTEGER,
    codProduto1 INTEGER,
    compProd_qtdeAcertada INTEGER,
    CONSTRAINT PK_TBCOMPRAPRODUTO PRIMARY KEY (codCompra, codProduto)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCONTASRECEBER"                                            */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCONTASRECEBER (
    codContaReceber SERIAL  NOT NULL,
    contRec_dataVencimento DATE,
    contRec_dataPagamento DATE,
    contRec_valorTotal NUMERIC(10,2),
    contRec_obs CHARACTER VARYING(300),
    codContrato INTEGER,
    codVenda INTEGER,
    codComissao INTEGER,
    codCaixa INTEGER  NOT NULL,
    codFormaPag INTEGER,
    codPessoa INTEGER,
    codFiado INTEGER,
    CONSTRAINT PK_TBCONTASRECEBER PRIMARY KEY (codContaReceber)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBCAIXA"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBCAIXA (
    codCaixa SERIAL  NOT NULL,
    caixa_periodo CHARACTER VARYING(40),
    caixa_dataHoraAbertura TIMESTAMP WITH TIME ZONE,
    caixa_dataHoraFecha TIMESTAMP WITH TIME ZONE,
    caixa_SaldoInicial NUMERIC(10,2),
    caixa_troco NUMERIC(10,2),
    caixa_TotalEntra NUMERIC(10,2),
    caixa_totalSaida NUMERIC(10,2),
    codUsuario INTEGER,
    codPessoa INTEGER,
    CONSTRAINT PK_TBCAIXA PRIMARY KEY (codCaixa)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPARAMETRO"                                                */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPARAMETRO (
    codParametro SERIAL  NOT NULL,
    param_razao CHARACTER VARYING(100),
    param_fantasia CHARACTER VARYING(100),
    param_email CHARACTER VARYING(100),
    param_logradouro CHARACTER VARYING(100),
    param_complemento CHARACTER VARYING(100),
    param_numero CHARACTER VARYING(100),
    param_fone CHARACTER VARYING(40),
    param_cel CHARACTER VARYING(40),
    param_logo CHARACTER VARYING(40),
    CONSTRAINT PK_TBPARAMETRO PRIMARY KEY (codParametro)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBFORMAPAGAMENTO"                                           */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBFORMAPAGAMENTO (
    codFormaPag SERIAL  NOT NULL,
    formPag_descricao CHARACTER VARYING(100),
    CONSTRAINT PK_TBFORMAPAGAMENTO PRIMARY KEY (codFormaPag)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBPRESTADORSERVICO"                                         */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBPRESTADORSERVICO (
    codPessoa INTEGER  NOT NULL,
    codTipoServico INTEGER  NOT NULL,
    prestServ_valor NUMERIC(10,2),
    prestServ_percentual NUMERIC(10,2),
    prestSer_PagRec CHARACTER VARYING(40),
    jur_cnpj CHARACTER VARYING(40)  NOT NULL,
    CONSTRAINT PK_TBPRESTADORSERVICO PRIMARY KEY (codPessoa, codTipoServico, jur_cnpj)
);

/* ---------------------------------------------------------------------- */
/* Add table "TBFIADO"                                                    */
/* ---------------------------------------------------------------------- */

CREATE TABLE TBFIADO (
    codPessoa INTEGER  NOT NULL,
    codFiado INTEGER  NOT NULL,
    fia_dataabertura DATE,
    fia_datafechamento DATE,
    fia_valortotal NUMERIC(10,2),
    fia_status CHARACTER(2),
    fia_valorpago NUMERIC(10,2),
    fia_valorrestante NUMERIC(10,2),
    codAgenda INTEGER,
    codVenda INTEGER,
    CONSTRAINT PK_TBFIADO PRIMARY KEY (codFiado)
);

/* ---------------------------------------------------------------------- */
/* Foreign key constraints                                                */
/* ---------------------------------------------------------------------- */

ALTER TABLE TBCIDADE ADD CONSTRAINT TBESTADO_TBCIDADE 
    FOREIGN KEY (codUf) REFERENCES TBESTADO (codUf);

ALTER TABLE TBENDERECO ADD CONSTRAINT TBCIDADE_TBENDERECO 
    FOREIGN KEY (codCidade, codUf) REFERENCES TBCIDADE (codCidade,codUf);

ALTER TABLE TBENDERECO ADD CONSTRAINT TBPESSOA_TBENDERECO 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBCONTATO ADD CONSTRAINT TBPESSOA_TBCONTATO 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBFISICA ADD CONSTRAINT TBPESSOA_TBFISICA 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBJURIDICA ADD CONSTRAINT TBPESSOA_TBJURIDICA 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBUSUARIO ADD CONSTRAINT TBPESSOA_TBUSUARIO 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBCOMPRA ADD CONSTRAINT TBDESPESA_TBCOMPRA 
    FOREIGN KEY (codDespesa) REFERENCES TBDESPESA (codDespesa);

ALTER TABLE TBCOMPRA ADD CONSTRAINT TBJURIDICA_TBCOMPRA 
    FOREIGN KEY (jur_cnpj) REFERENCES TBJURIDICA (jur_cnpj);

ALTER TABLE TBAGENDA ADD CONSTRAINT TBPESSOA_TBAGENDA 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBAGENDA ADD CONSTRAINT TBCOMISSAO_TBAGENDA 
    FOREIGN KEY (codComissao) REFERENCES TBCOMISSAO (codComissao);

ALTER TABLE TBAGENDA ADD CONSTRAINT TBCONTRATO_TBAGENDA 
    FOREIGN KEY (codContrato) REFERENCES TBCONTRATO (codContrato);

ALTER TABLE TBPRODUTO ADD CONSTRAINT TBCATEGORIA_TBPRODUTO 
    FOREIGN KEY (codCategoria) REFERENCES TBCATEGORIA (codCategoria);

ALTER TABLE TBPRODUTO ADD CONSTRAINT TBMARCA_TBPRODUTO 
    FOREIGN KEY (codMarca) REFERENCES TBMARCA (codMarca);

ALTER TABLE TBBAIXA ADD CONSTRAINT TBPRODUTO_TBBAIXA 
    FOREIGN KEY (codProduto) REFERENCES TBPRODUTO (codProduto);

ALTER TABLE TBCONTASPAGAR ADD CONSTRAINT TBCOMPRA_TBCONTASPAGAR 
    FOREIGN KEY (codCompra) REFERENCES TBCOMPRA (codCompra);

ALTER TABLE TBCONTASPAGAR ADD CONSTRAINT TBDESPESA_TBCONTASPAGAR 
    FOREIGN KEY (codDespesa) REFERENCES TBDESPESA (codDespesa);

ALTER TABLE TBCONTASPAGAR ADD CONSTRAINT TBCAIXA_TBCONTASPAGAR 
    FOREIGN KEY (codCaixa) REFERENCES TBCAIXA (codCaixa);

ALTER TABLE TBCONTASPAGAR ADD CONSTRAINT TBFORMAPAGAMENTO_TBCONTASPAGAR 
    FOREIGN KEY (codFormaPag) REFERENCES TBFORMAPAGAMENTO (codFormaPag);

ALTER TABLE TBCONTASPAGAR ADD CONSTRAINT TBCOMISSAO_TBCONTASPAGAR 
    FOREIGN KEY (codComissao) REFERENCES TBCOMISSAO (codComissao);

ALTER TABLE TBCONTRATO ADD CONSTRAINT TBPACOTE_TBCONTRATO 
    FOREIGN KEY (codPacote) REFERENCES TBPACOTE (codPacote);

ALTER TABLE TBCONTRATO ADD CONSTRAINT TBFISICA_TBCONTRATO 
    FOREIGN KEY (fis_cpf) REFERENCES TBFISICA (fis_cpf);

ALTER TABLE TBPACOTESADICIONAIS ADD CONSTRAINT TBTIPOSERVICO_TBPACOTESADICIONAIS 
    FOREIGN KEY (codTipoServico) REFERENCES TBTIPOSERVICO (codTipoServico);

ALTER TABLE TBPACOTESADICIONAIS ADD CONSTRAINT TBCONTRATO_TBPACOTESADICIONAIS 
    FOREIGN KEY (codContrato) REFERENCES TBCONTRATO (codContrato);

ALTER TABLE TBPACOTESERVICO ADD CONSTRAINT TBPACOTE_TBPACOTESERVICO 
    FOREIGN KEY (codPacote) REFERENCES TBPACOTE (codPacote);

ALTER TABLE TBPACOTESERVICO ADD CONSTRAINT TBTIPOSERVICO_TBPACOTESERVICO 
    FOREIGN KEY (codTipoServico) REFERENCES TBTIPOSERVICO (codTipoServico);

ALTER TABLE TBVENDA ADD CONSTRAINT TBPESSOA_TBVENDA 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBVENDAPRODUTO ADD CONSTRAINT TBVENDA_TBVENDAPRODUTO 
    FOREIGN KEY (codVenda) REFERENCES TBVENDA (codVenda);

ALTER TABLE TBVENDAPRODUTO ADD CONSTRAINT TBPRODUTO_TBVENDAPRODUTO 
    FOREIGN KEY (codProduto) REFERENCES TBPRODUTO (codProduto);

ALTER TABLE TBCOMPRAPRODUTO ADD CONSTRAINT TBCOMPRA_TBCOMPRAPRODUTO 
    FOREIGN KEY (codCompra) REFERENCES TBCOMPRA (codCompra);

ALTER TABLE TBCOMPRAPRODUTO ADD CONSTRAINT TBPRODUTO_TBCOMPRAPRODUTO 
    FOREIGN KEY (codProduto) REFERENCES TBPRODUTO (codProduto);

ALTER TABLE TBCOMPRAPRODUTO ADD CONSTRAINT TBCOMPRAPRODUTO_TBCOMPRAPRODUTO 
    FOREIGN KEY (codCompra1, codProduto1) REFERENCES TBCOMPRAPRODUTO (codCompra,codProduto);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBCONTRATO_TBCONTASRECEBER 
    FOREIGN KEY (codContrato) REFERENCES TBCONTRATO (codContrato);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBVENDA_TBCONTASRECEBER 
    FOREIGN KEY (codVenda) REFERENCES TBVENDA (codVenda);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBCOMISSAO_TBCONTASRECEBER 
    FOREIGN KEY (codComissao) REFERENCES TBCOMISSAO (codComissao);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBCAIXA_TBCONTASRECEBER 
    FOREIGN KEY (codCaixa) REFERENCES TBCAIXA (codCaixa);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBFORMAPAGAMENTO_TBCONTASRECEBER 
    FOREIGN KEY (codFormaPag) REFERENCES TBFORMAPAGAMENTO (codFormaPag);

ALTER TABLE TBCONTASRECEBER ADD CONSTRAINT TBFIADO_TBCONTASRECEBER 
    FOREIGN KEY (codFiado) REFERENCES TBFIADO (codFiado);

ALTER TABLE TBCAIXA ADD CONSTRAINT TBUSUARIO_TBCAIXA 
    FOREIGN KEY (codUsuario, codPessoa) REFERENCES TBUSUARIO (codUsuario,codPessoa);

ALTER TABLE TBPRESTADORSERVICO ADD CONSTRAINT TBJURIDICA_TBPRESTADORSERVICO 
    FOREIGN KEY (jur_cnpj) REFERENCES TBJURIDICA (jur_cnpj);

ALTER TABLE TBPRESTADORSERVICO ADD CONSTRAINT TBTIPOSERVICO_TBPRESTADORSERVICO 
    FOREIGN KEY (codTipoServico) REFERENCES TBTIPOSERVICO (codTipoServico);

ALTER TABLE TBFIADO ADD CONSTRAINT TBPESSOA_TBFIADO 
    FOREIGN KEY (codPessoa) REFERENCES TBPESSOA (codPessoa);

ALTER TABLE TBFIADO ADD CONSTRAINT TBAGENDA_TBFIADO 
    FOREIGN KEY (codAgenda) REFERENCES TBAGENDA (codAgenda);

ALTER TABLE TBFIADO ADD CONSTRAINT TBVENDA_TBFIADO 
    FOREIGN KEY (codVenda) REFERENCES TBVENDA (codVenda);
