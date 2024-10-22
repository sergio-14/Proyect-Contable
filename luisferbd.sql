USE [BD_sistema]
GO
/****** Object:  Table [dbo].[T_Balances]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Balances](
	[Id_B] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Cuenta2] [numeric](18, 0) NOT NULL,
	[Id_BM] [bigint] NOT NULL,
	[N] [numeric](18, 0) NOT NULL,
	[SumaD] [varchar](max) NOT NULL,
	[SumaH] [varchar](max) NOT NULL,
	[Deudor] [varchar](max) NOT NULL,
	[Acreedor] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_B] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Cuenta]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Cuenta](
	[Id_Cuenta] [numeric](18, 0) NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Codigo] [bigint] IDENTITY(1,1) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Cuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Glosa]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Glosa](
	[Id_G] [bigint] IDENTITY(1,1) NOT NULL,
	[Glosa] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_G] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Libro]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Libro](
	[Id_L] [bigint] IDENTITY(1,1) NOT NULL,
	[Id_Cuenta1] [numeric](18, 0) NOT NULL,
	[Folio] [numeric](18, 0) NOT NULL,
	[Debe] [varchar](max) NOT NULL,
	[Haber] [varchar](max) NOT NULL,
	[Id_G1] [bigint] NOT NULL,
	[Id_Mes1] [bigint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_L] ASC,
	[Id_Cuenta1] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Mayor]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Mayor](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[detalle] [varchar](max) NULL,
	[debe] [varchar](max) NULL,
	[haber] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Mes]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Mes](
	[Id_Mes] [bigint] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NULL,
	[fecha] [datetime] NOT NULL,
	[Mes] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Mes] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/15/2023 8:38:42 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nom_usu] [varchar](50) NOT NULL,
	[account] [varchar](50) NOT NULL,
	[passwor] [varchar](50) NOT NULL,
	[statuc] [bit] NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[T_Balances] ON 

INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10168, CAST(411 AS Numeric(18, 0)), 10073, CAST(1 AS Numeric(18, 0)), N'123', N'123', N'0', N'0')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10169, CAST(623 AS Numeric(18, 0)), 10073, CAST(2 AS Numeric(18, 0)), N'20.01', N'23', N'0', N'2.99')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10170, CAST(134322 AS Numeric(18, 0)), 10073, CAST(3 AS Numeric(18, 0)), N'3.25', N'0', N'3.25', N'0')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10171, CAST(11131 AS Numeric(18, 0)), 10073, CAST(4 AS Numeric(18, 0)), N'0', N'2277', N'0', N'2277')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10172, CAST(627 AS Numeric(18, 0)), 10073, CAST(5 AS Numeric(18, 0)), N'1.74', N'0', N'1.74', N'0')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10173, CAST(2132 AS Numeric(18, 0)), 10073, CAST(6 AS Numeric(18, 0)), N'0', N'2', N'0', N'2')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10174, CAST(35 AS Numeric(18, 0)), 10073, CAST(7 AS Numeric(18, 0)), N'2', N'0', N'2', N'0')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10175, CAST(635 AS Numeric(18, 0)), 10073, CAST(8 AS Numeric(18, 0)), N'0', N'1.74', N'0', N'1.74')
INSERT [dbo].[T_Balances] ([Id_B], [Id_Cuenta2], [Id_BM], [N], [SumaD], [SumaH], [Deudor], [Acreedor]) VALUES (10176, CAST(11543412 AS Numeric(18, 0)), 10073, CAST(9 AS Numeric(18, 0)), N'0', N'0.26', N'0', N'0.26')
SET IDENTITY_INSERT [dbo].[T_Balances] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Cuenta] ON 

INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(31 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Capital Social', 78)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(32 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Reserva Para Revaluos Tecnicos', 79)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(33 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Reserva Legal', 80)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(34 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Reserva Constitutaria', 81)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(35 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Ajuste Global Del Patrimonio', 82)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(36 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Utilidades Retenidas', 83)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(37 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Perdidas Acumuladas', 84)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(38 AS Numeric(18, 0)), N'Patriminio o Capital Contable', N'Utilidad de la Gestion', 85)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(51 AS Numeric(18, 0)), N'Costo de Mercaderia Vendida', N'Inventario Inicial de Mercaderias', 99)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(52 AS Numeric(18, 0)), N'Costo de Mercaderia Vendida', N'Compras', 100)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(71 AS Numeric(18, 0)), N'Otros Gastos', N'Perdidas en Ventas de Bienes de Uso', 140)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(72 AS Numeric(18, 0)), N'Otros Gastos', N'Diferencia de Cambio', 141)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(73 AS Numeric(18, 0)), N'Otros Gastos', N'Perdida Por Siniestro', 142)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(81 AS Numeric(18, 0)), N'Transitorio o de Estadistica', N'Perdidas y Ganancias', 143)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(151 AS Numeric(18, 0)), N'Cuentas de Orden', N'Mercaderias Recibidas en Consignacion', 43)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(152 AS Numeric(18, 0)), N'Cuentas de Orden', N'Valores en Garantias', 44)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(211 AS Numeric(18, 0)), N'Cuentas a Pagar', N'Cuentas a Pagar', 45)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(212 AS Numeric(18, 0)), N'Documentos a Pagar', N'Documentos a Pagar', 46)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(216 AS Numeric(18, 0)), N'Debito Oficial', N'Debito Oficial', 64)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(222 AS Numeric(18, 0)), N'Obligaciones Por Emision de Bonos', N'Obligaciones Por Emision de Bonos', 75)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(231 AS Numeric(18, 0)), N'Prevision Para Indemnizacion', N'Prevision Para Indemnizacion', 76)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(241 AS Numeric(18, 0)), N'Operaciones Pendientes', N'Operaciones Pendientes', 77)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(391 AS Numeric(18, 0)), N'Cuentas de Orden', N'Comitentes y Consignantes', 86)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(392 AS Numeric(18, 0)), N'Cuentas de Orden', N'Depositantes de Valores en Garantias', 87)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(411 AS Numeric(18, 0)), N'Ingresos Ordinarios', N'Ventas', 88)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(412 AS Numeric(18, 0)), N'Ingresos Ordinarios', N'Recargo Sobre Ventas', 89)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(413 AS Numeric(18, 0)), N'Ingresos Ordinarios', N'Devolucion Sobre Ventas', 90)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(421 AS Numeric(18, 0)), N'Ingresos no Ordinarios', N'Ventas de Desperdicios', 91)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(422 AS Numeric(18, 0)), N'Ingresos no Ordinarios', N'Comisiones Percibidas', 92)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(423 AS Numeric(18, 0)), N'Ingresos no Ordinarios', N'Ganancias en Ventas de Bienes de Uso', 93)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(431 AS Numeric(18, 0)), N'Productos Financieros', N'Intereses Percibidos', 94)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(432 AS Numeric(18, 0)), N'Productos Financieros', N'Diferencias de Cambio (Saldo Acreedor)', 95)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(433 AS Numeric(18, 0)), N'Productos Financieros', N'Desc. Por Pronto Pago en Compras', 96)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(434 AS Numeric(18, 0)), N'Productos Financieros', N'Bonificacion en Compras', 97)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(435 AS Numeric(18, 0)), N'Productos Financieros', N'Resultado Por Exposic. a la Infl.', 98)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(521 AS Numeric(18, 0)), N'Costo de Mercaderia Vendida', N'Recargo Sobre Compras', 101)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(522 AS Numeric(18, 0)), N'Costo de Mercaderia Vendida', N'Fletes y Acarreos Sobres Compras', 102)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(523 AS Numeric(18, 0)), N'Costo de Mercaderia Vendida', N'Devolucion Sobre Compras', 103)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(612 AS Numeric(18, 0)), N'Gastos de Administracion', N'Cargas Sociales', 104)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(617 AS Numeric(18, 0)), N'Gastos de Administracion', N'Depreciacion Bienes de Uso', 105)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(618 AS Numeric(18, 0)), N'Gastos de Administracion', N'Donaciones y Obsequios', 106)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(621 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Sueldo y Salarios', 117)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(623 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Alquileres', 118)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(624 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Aseo y Limpieza', 119)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(625 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Atencion Medica y Sociales', 120)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(626 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Comision a Vendedores', 121)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(627 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Agua y Alcantarillado', 122)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(631 AS Numeric(18, 0)), N'Gastos Financieros', N'Descto. Pronto Pago en Ventas', 135)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(632 AS Numeric(18, 0)), N'Gastos Financieros', N'Diferencia de Cambio (Saldo Deudor)', 136)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(633 AS Numeric(18, 0)), N'Gastos Financieros', N'Diferencia Por Redondeo (S. Deudor)', 137)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(634 AS Numeric(18, 0)), N'Gastos Financieros', N'Intereses y Cargos Financieros', 138)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(635 AS Numeric(18, 0)), N'Gastos Financieros', N'Bonificacion en Ventas', 139)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1111 AS Numeric(18, 0)), N'Disponible', N'Caja', 5)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1112 AS Numeric(18, 0)), N'Disponible', N'Caja Chica', 8)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1113 AS Numeric(18, 0)), N'Disponible', N'Bancos', 9)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1114 AS Numeric(18, 0)), N'Disponible', N'Caja De Ahorro', 12)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1115 AS Numeric(18, 0)), N'Disponible', N'Deposito A Plazo Fijo', 13)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1121 AS Numeric(18, 0)), N'Creditos o Exigible', N'Cuentas a Cobrar', 14)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1122 AS Numeric(18, 0)), N'Creditos o Exigible', N'Documentos a Cobrar', 15)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1123 AS Numeric(18, 0)), N'Creditos o Exigible', N'Sucursal Cta.', 16)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1124 AS Numeric(18, 0)), N'Creditos o Exigible', N'Credito Fiscal', 17)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1125 AS Numeric(18, 0)), N'Creditos o Exigible', N'Anticipo de Impuesto', 18)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1126 AS Numeric(18, 0)), N'Creditos o Exigible', N'Cuenta a Cobrar Empleados', 19)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1127 AS Numeric(18, 0)), N'Creditos o Exigible', N'Cta. Personal Socios', 20)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1128 AS Numeric(18, 0)), N'Creditos o Exigible', N'Deudores Con Cargos De Cuentas', 21)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1129 AS Numeric(18, 0)), N'Creditos o Exigible', N'Otros Deudores', 22)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1131 AS Numeric(18, 0)), N'Bienes de Cambio o Realizable', N'Inv. de Mercaderia', 23)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1132 AS Numeric(18, 0)), N'Bienes de Cambio o Realizable', N'Mercaderia en Transito', 24)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1133 AS Numeric(18, 0)), N'Bienes de Cambio o Realizable', N'Anticipo a Proveedores', 25)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1141 AS Numeric(18, 0)), N'Inversiones', N'Participaciones', 26)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1142 AS Numeric(18, 0)), N'Inversiones', N'Acciones', 27)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1211 AS Numeric(18, 0)), N'Bienes de Uso', N'Terreno', 28)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1212 AS Numeric(18, 0)), N'Bienes de Uso', N'Edificios', 29)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1213 AS Numeric(18, 0)), N'Bienes de Uso', N'Muebles y Enseres', 30)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1214 AS Numeric(18, 0)), N'Bienes de Uso', N'Maquinaria y Equipo', 31)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1215 AS Numeric(18, 0)), N'Bienes de Uso', N'Vehiculos', 32)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1216 AS Numeric(18, 0)), N'Bienes de Uso', N'Equipos de Computacion', 33)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1221 AS Numeric(18, 0)), N'Disponible', N'Gasto IT.', 1)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1231 AS Numeric(18, 0)), N'Intangibles', N'Credito Mercantil', 34)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1232 AS Numeric(18, 0)), N'Intangibles', N'Marcas de Fabricas', 35)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1234 AS Numeric(18, 0)), N'Nueva', N'paneton', 144)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1251 AS Numeric(18, 0)), N'Diferidos', N'Terrenos Para Futuras Construcciones', 36)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(1252 AS Numeric(18, 0)), N'Diferidos', N'Materiales en Transito', 37)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2131 AS Numeric(18, 0)), N'Obligaciones Con el Personal', N'Sueldo y Salario a Pagar', 47)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2132 AS Numeric(18, 0)), N'Obligaciones Con el Personal', N'Aguinaldo a Pagar', 48)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2133 AS Numeric(18, 0)), N'Obligaciones Con el Personal', N'Finiquitos a Pagar', 49)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2141 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'Adm. Fondo de Penciones', 50)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2142 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'Caja Ncional de Salud', 53)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2143 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'AFPS (PROVIVIENDA)', 54)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2144 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'Instituto de Formacion y Capacitacion Laboral', 55)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2145 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'Impuesto', 56)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2151 AS Numeric(18, 0)), N'Impuesto a Pagar', N'Impuesto a las Transacciones', 62)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2152 AS Numeric(18, 0)), N'Impuesto a Pagar', N'Impuesto Sobres Utilidades', 63)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2171 AS Numeric(18, 0)), N'Obligaciones Bancarios a Pagar', N'Prestamos Hipotecarios', 65)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2172 AS Numeric(18, 0)), N'Obligaciones Bancarios a Pagar', N'Prestamos Documentarios', 66)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2173 AS Numeric(18, 0)), N'Obligaciones Bancarios a Pagar', N'Documentos a Cobrar Descontados', 67)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2174 AS Numeric(18, 0)), N'Obligaciones Bancarios a Pagar', N'Documentos Descontados', 68)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2181 AS Numeric(18, 0)), N'Otros Acreedores', N'Empresa de luz y Fuerza', 69)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2182 AS Numeric(18, 0)), N'Otros Acreedores', N'Semapa', 70)
GO
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2183 AS Numeric(18, 0)), N'Otros Acreedores', N'Empresa de Transporte, etc.', 71)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2191 AS Numeric(18, 0)), N'Ingresos Cobrados Por Adelantado', N'Alquileres Cobrados Por Anticipado', 72)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2192 AS Numeric(18, 0)), N'Ingresos Cobrados Por Adelantado', N'Intereses Cobrados Por Anticipado', 73)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(2193 AS Numeric(18, 0)), N'Ingresos Cobrados Por Adelantado', N'Anticipo de Clientes', 74)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6115 AS Numeric(18, 0)), N'Gastos de Administracion', N'Impto. a la Prop. B. Inmuebles y Vehiculo', 107)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6116 AS Numeric(18, 0)), N'Gastos de Administracion', N'Impto. Municipal a las Transferencias', 108)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6117 AS Numeric(18, 0)), N'Gastos de Administracion', N'Mantenimiento Vehiculos', 109)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6118 AS Numeric(18, 0)), N'Gastos de Administracion', N'Material de Escritorio', 110)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6119 AS Numeric(18, 0)), N'Gastos de Administracion', N'Mermas y Fallas en Inventarios', 111)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6120 AS Numeric(18, 0)), N'Gastos de Administracion', N'Multa Por Incumplimiento', 112)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6123 AS Numeric(18, 0)), N'Gastos de Administracion', N'Perdida en Ctas. Incobrables', 113)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6128 AS Numeric(18, 0)), N'Gastos de Administracion', N'Vacaciones', 114)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6129 AS Numeric(18, 0)), N'Gastos de Administracion', N'Viaticos y Gastos de Representacion', 115)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6130 AS Numeric(18, 0)), N'Gastos de Administracion', N'vigilancia', 116)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6210 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Energia Electrica', 123)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6211 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Fletes Sobre Ventas', 124)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6212 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Fotocopias: Rep. Comprob. y Form.', 125)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6213 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Gastos de Comunicacion', 126)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6214 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Gastos Generales', 127)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6215 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Gastos Judiciales y Legales', 128)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6223 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Otros Beneficios al Personal .....', 129)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6224 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Publicidad y Promocion', 130)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6225 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Pasajes y Viaticos', 131)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6226 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Rep. y Mant. Eq. de Computacion', 132)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6228 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Servicios de Te y Refrigerio', 133)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(6229 AS Numeric(18, 0)), N'Gastos de Distribucion o Ventas', N'Tasas y Pantentes Municipales', 134)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(11111 AS Numeric(18, 0)), N'Disponible', N'Caja Moneda Nacional', 6)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(11112 AS Numeric(18, 0)), N'Disponible', N'Caja Moneda Extranjera', 7)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(11131 AS Numeric(18, 0)), N'Disponible', N'Bancos Moneda Nacional', 10)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(11132 AS Numeric(18, 0)), N'Disponible', N'Bancos Moneda Extranjeras', 11)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12345 AS Numeric(18, 0)), N'Nueva', N'cajar', 145)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12431 AS Numeric(18, 0)), N'Diferidos', N'Seguros', 38)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12433 AS Numeric(18, 0)), N'Diferidos', N'Intereses', 39)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12434 AS Numeric(18, 0)), N'Diferidos', N'Inv. Material de Escritorio', 40)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12435 AS Numeric(18, 0)), N'Diferidos', N'Gastos de Publicidad', 41)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(12436 AS Numeric(18, 0)), N'Diferidos', N'Gastos de Organizacion', 42)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21411 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'Previsión BBV', 51)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21412 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'El Futuro de Bolivia', 52)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21451 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'RC-IVA a Dependientes', 57)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21452 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'RC-IVA a Terceros', 58)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21453 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'I.V.A. a Terceros', 59)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21454 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'I.T. a Terceros', 60)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(21455 AS Numeric(18, 0)), N'Aporte y Retenciones a Pagar', N'I.U.E. a Terceros', 61)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(134322 AS Numeric(18, 0)), N'Disponible', N'Iva CF', 3)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(11543412 AS Numeric(18, 0)), N'Disponible', N'Iva DF', 4)
INSERT [dbo].[T_Cuenta] ([Id_Cuenta], [Tipo], [Nombre], [Codigo]) VALUES (CAST(65441111 AS Numeric(18, 0)), N'Disponible', N'IT. x Pagar', 2)
SET IDENTITY_INSERT [dbo].[T_Cuenta] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Glosa] ON 

INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (1, N'pan')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (2, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (3, N'erasfc')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10003, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10004, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10005, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10006, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10007, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10008, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10009, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10010, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10011, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10012, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10013, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10014, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10015, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10016, N'plan comun')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10017, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10018, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10019, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10020, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10021, N'')
INSERT [dbo].[T_Glosa] ([Id_G], [Glosa]) VALUES (10022, N'balance')
SET IDENTITY_INSERT [dbo].[T_Glosa] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Libro] ON 

INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (1, CAST(411 AS Numeric(18, 0)), CAST(1 AS Numeric(18, 0)), N'123', N'123', 1, 1)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10013, CAST(623 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'20.01', N'0', 10013, 10063)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10014, CAST(134322 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'2.99', N'0', 10014, 10064)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10015, CAST(623 AS Numeric(18, 0)), CAST(2 AS Numeric(18, 0)), N'0', N'23', 10015, 10065)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10016, CAST(11131 AS Numeric(18, 0)), CAST(4 AS Numeric(18, 0)), N'0', N'2277', 10016, 10066)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10017, CAST(627 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), N'1.74', N'0', 10017, 10067)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10018, CAST(134322 AS Numeric(18, 0)), CAST(3 AS Numeric(18, 0)), N'0.26', N'0', 10018, 10068)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10019, CAST(2132 AS Numeric(18, 0)), CAST(6 AS Numeric(18, 0)), N'0', N'2', 10019, 10069)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10020, CAST(35 AS Numeric(18, 0)), CAST(7 AS Numeric(18, 0)), N'2', N'0', 10020, 10070)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10021, CAST(635 AS Numeric(18, 0)), CAST(8 AS Numeric(18, 0)), N'0', N'1.74', 10021, 10071)
INSERT [dbo].[T_Libro] ([Id_L], [Id_Cuenta1], [Folio], [Debe], [Haber], [Id_G1], [Id_Mes1]) VALUES (10022, CAST(11543412 AS Numeric(18, 0)), CAST(9 AS Numeric(18, 0)), N'0', N'0.26', 10022, 10072)
SET IDENTITY_INSERT [dbo].[T_Libro] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Mayor] ON 

INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (69, N'Ventas', N'123', N'123')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (70, N'Alquileres', N'20.01', N'23')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (71, N'Iva CF', N'3.25', N'0')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (72, N'Bancos Moneda Nacional', N'0', N'2277')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (73, N'Agua y Alcantarillado', N'1.74', N'0')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (74, N'Aguinaldo a Pagar', N'0', N'2')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (75, N'Ajuste Global Del Patrimonio', N'2', N'0')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (76, N'Bonificacion en Ventas', N'0', N'1.74')
INSERT [dbo].[T_Mayor] ([id], [detalle], [debe], [haber]) VALUES (77, N'Iva DF', N'0', N'0.26')
SET IDENTITY_INSERT [dbo].[T_Mayor] OFF
GO
SET IDENTITY_INSERT [dbo].[T_Mes] ON 

INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (1, N'fecha', CAST(N'2022-04-12T00:00:00.000' AS DateTime), CAST(N'2022-04-12T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (2, N'LIbro', CAST(N'2023-11-07T00:00:00.000' AS DateTime), CAST(N'2023-11-07T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (3, N'LIbro', CAST(N'2023-11-07T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10033, N'LIbro', CAST(N'2023-12-01T00:00:00.000' AS DateTime), CAST(N'2023-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10034, N'LIbro', CAST(N'2023-12-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10035, N'LIbro', CAST(N'2023-12-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10036, N'LIbro', CAST(N'2023-12-01T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10043, N'LIbro', CAST(N'2023-12-02T00:00:00.000' AS DateTime), CAST(N'2023-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10051, N'LIbro', CAST(N'2023-12-02T00:00:00.000' AS DateTime), CAST(N'2023-12-02T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10052, N'LIbro', CAST(N'2023-12-22T00:00:00.000' AS DateTime), CAST(N'2023-12-22T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10053, N'LIbro', CAST(N'2023-12-22T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10054, N'LIbro', CAST(N'2023-12-22T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10055, N'LIbro', CAST(N'2023-12-22T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10063, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), CAST(N'2023-12-15T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10064, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10065, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10066, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10067, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), CAST(N'2023-12-15T00:00:00.000' AS DateTime))
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10068, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10069, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10070, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10071, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10072, N'LIbro', CAST(N'2023-12-15T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[T_Mes] ([Id_Mes], [Nombre], [fecha], [Mes]) VALUES (10073, N'Balance', CAST(N'2023-12-15T00:00:00.000' AS DateTime), CAST(N'2023-12-15T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[T_Mes] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuario] ON 

INSERT [dbo].[Usuario] ([id], [Nom_usu], [account], [passwor], [statuc]) VALUES (5, N'conta', N'conta', N'123', 1)
INSERT [dbo].[Usuario] ([id], [Nom_usu], [account], [passwor], [statuc]) VALUES (6, N'luisfer', N'luisfer', N'123', 0)
SET IDENTITY_INSERT [dbo].[Usuario] OFF
GO
ALTER TABLE [dbo].[T_Balances]  WITH CHECK ADD FOREIGN KEY([Id_BM])
REFERENCES [dbo].[T_Mes] ([Id_Mes])
GO
ALTER TABLE [dbo].[T_Balances]  WITH CHECK ADD FOREIGN KEY([Id_Cuenta2])
REFERENCES [dbo].[T_Cuenta] ([Id_Cuenta])
GO
ALTER TABLE [dbo].[T_Libro]  WITH CHECK ADD FOREIGN KEY([Id_Cuenta1])
REFERENCES [dbo].[T_Cuenta] ([Id_Cuenta])
GO
ALTER TABLE [dbo].[T_Libro]  WITH CHECK ADD FOREIGN KEY([Id_G1])
REFERENCES [dbo].[T_Glosa] ([Id_G])
GO
ALTER TABLE [dbo].[T_Libro]  WITH CHECK ADD FOREIGN KEY([Id_Mes1])
REFERENCES [dbo].[T_Mes] ([Id_Mes])
GO
/****** Object:  StoredProcedure [dbo].[A_T_Glosa]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[A_T_Glosa]
@Id_G bigint,
@Glosa varchar(MAX)
as begin
update T_Glosa set Glosa=@Glosa where Id_G=@Id_G
end 
GO
/****** Object:  StoredProcedure [dbo].[A_Usuario]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[A_Usuario]
@id bit,
@Nom_usu varchar(50),
@account varchar(50)
as
begin
update Usuario set Nom_usu=@Nom_usu,account=@account where id=@id
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Balances]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 
create procedure [dbo].[I_T_Balances]
@Id_Cuenta2 numeric,
@Id_BM bigint ,
@N numeric ,
@SumaD varchar(max),
@SumaH varchar(max),
@Deudor varchar(max),
@Acreedor varchar(max)
as begin 
insert into T_Balances (Id_Cuenta2, Id_BM, N, SumaD, SumaH, Deudor, Acreedor) values (@Id_Cuenta2, @Id_BM, @N, @SumaD, @SumaH, @Deudor, @Acreedor)
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Cuenta]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[I_T_Cuenta]
@Id_Cuenta numeric,
@Tipo varchar(50),
@Nombre varchar(50)
as
begin
insert into T_Cuenta(Id_Cuenta,Tipo,Nombre) values (@Id_Cuenta,@Tipo,@Nombre)
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Glosa]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[I_T_Glosa]
@Glosa varchar(MAX)
as begin
insert into T_Glosa (Glosa)values(@Glosa)
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Libro]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[I_T_Libro]
@Id_Cuenta1 numeric,
@Folio numeric,
@Debe varchar(max),
@Haber varchar(max),
@Id_G1 bigint,
@Id_Mes1 numeric
as
begin
insert into T_Libro (Id_Cuenta1,Folio,Debe,Haber,Id_G1,Id_Mes1)values(@Id_Cuenta1,@Folio,@Debe,@Haber,@Id_G1,@Id_Mes1)
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Mayor]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[I_T_Mayor]
@detalle varchar(max),
@debe varchar(max),
@haber varchar(max)
as
begin
insert into T_Mayor (detalle,debe,haber) values (@detalle,@debe,@haber)
end
GO
/****** Object:  StoredProcedure [dbo].[I_T_Mes]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[I_T_Mes]
@Nombre varchar(100),
@fecha datetime,
@Mes datetime
as
begin
insert into T_Mes (Nombre,fecha,Mes)values (@Nombre,@fecha,@Mes)
end 
GO
/****** Object:  StoredProcedure [dbo].[I_T_MesR]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[I_T_MesR]
@Nombre varchar(100),
@fecha datetime
as
begin
insert into T_Mes (Nombre,fecha)values (@Nombre,@fecha)
end 
GO
/****** Object:  StoredProcedure [dbo].[I_Usuario]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[I_Usuario]
@Nom_usu varchar(50),
@account varchar(50),
@passwor varchar(50),
@statuc bit
as 
begin 
insert into Usuario (Nom_usu,account,passwor,statuc) values(@Nom_usu,@account,@passwor,@statuc)
end
GO
/****** Object:  StoredProcedure [dbo].[Reporte_Balance]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Reporte_Balance]
as
begin
select b.N, c.Nombre,CONVERT(float,b.SumaD)as SumaD,CONVERT(float,b.SumaH)as SumaH,CONVERT(float,b.Deudor)as Deudor,CONVERT(float,b.Acreedor)as Acreedor from
T_Balances b inner join T_Cuenta c on b.Id_Cuenta2=c.Id_Cuenta where b.Id_BM=(select max(Id_Mes) from T_Mes where Nombre='Balance') 
end
GO
/****** Object:  StoredProcedure [dbo].[Reporte_Diario]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Reporte_Diario]
as
begin
select FORMAT(m.Mes,'ddd dd-MM-yyyy')as Mes ,c.Nombre,l.Folio,CONVERT(Float,l.Debe) as Debe,CONVERT(float,l.Haber)as Haber,g.Glosa from
T_Libro l inner join T_Cuenta c on l.Id_Cuenta1=c.Id_Cuenta inner join T_Mes m on m.Id_Mes=l.Id_Mes1 inner join T_Glosa g
on g.Id_G=l.Id_G1
end 
GO
/****** Object:  StoredProcedure [dbo].[Reporte_mayor]    Script Date: 12/15/2023 8:38:43 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Reporte_mayor]
as begin 
select detalle as [Nombre],CONVERT(float, debe)as debe,CONVERT(float, haber)as haber  from T_Mayor
 end 
GO
