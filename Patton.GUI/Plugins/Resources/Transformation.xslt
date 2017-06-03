<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0"
    xmlns:xsl="http://www.w3.org/1999/XSL/Transform" >

  <xsl:output method="html" encoding="iso-8859-1"/>
  <xsl:strip-space elements="*" />
  
	<xsl:template match="/">
      
     <xsl:apply-templates select="NotaCreditoEmitida/DatosCabecera"/>
     <xsl:apply-templates select="NotaCreditoEmitida/InformacionCliente"/>
    <xsl:apply-templates select="NotaCreditoEmitida/InformacionCliente/ContactoCliente"/>
    <xsl:apply-templates select="NotaCreditoEmitida/InformacionImpuestos"/>
    <xsl:apply-templates select="NotaCreditoEmitida/InformacionRetencion"/>
    <xsl:apply-templates select="NotaCreditoEmitida/InformacionResumen"/>
    <xsl:apply-templates select="NotaCreditoEmitida/NumerationExtension"/>
    
	</xsl:template>
	
	<xsl:template match="NotaCreditoEmitida/DatosCabecera">
    <xsl:value-of select="FechaNotaCredito"/>;
    <xsl:value-of select="HoraNotaCredito"/>;
  <xsl:value-of select="NumeroNotaCredito"/>;
    <xsl:value-of select="ClaseNotaCredito"/>;
    <xsl:value-of select="SociedadNotaCredito"/>;
    <xsl:value-of select="Referencia"/>;
    <xsl:value-of select="NumeroFacturaAsociada"/>;
    <xsl:value-of select="Observaciones01NotaCredito"/>;
  </xsl:template>

  <xsl:template match="NotaCreditoEmitida/InformacionCliente">
    <xsl:value-of select="TipoID"/>;
    <xsl:value-of select="NumeroID"/>;
    <xsl:value-of select="RazonSocial"/>;
    <xsl:value-of select="NombreRegistrado"/>;
    <xsl:value-of select="DireccionPostal"/>;
    <xsl:value-of select="Departamento"/>;
    <xsl:value-of select="Ciudad"/>;
    <xsl:value-of select="Pais"/>;
    <xsl:value-of select="TipoPersoneria"/>;
    <xsl:value-of select="TipoRegimen"/>;
    
  </xsl:template>

  <xsl:template match="NotaCreditoEmitida/InformacionCliente/ContactoCliente">
    <xsl:value-of select="Nombre"/>;
    <xsl:value-of select="Area"/>;
    <xsl:value-of select="Cargo"/>;
    <xsl:value-of select="Telefono"/>;
    <xsl:value-of select="Email"/>;
  </xsl:template>

  <xsl:template match="NotaCreditoEmitida/InformacionImpuestos">
    <xsl:value-of select="LineaImpuesto/CodigoImpuesto"/>;
    <xsl:value-of select="LineaImpuesto/DescripcionImpuesto"/>;
    <xsl:value-of select="LineaImpuesto/MonedaImpuesto"/>;
    <xsl:value-of select="LineaImpuesto/BaseImpuesto"/>;
    <xsl:value-of select="LineaImpuesto/PorcentajeImpuesto"/>;
    <xsl:value-of select="LineaImpuesto/ValorImpuesto"/>;
  </xsl:template>

  <xsl:template match="NotaCreditoEmitida/InformacionRetencion">
    <xsl:value-of select="LineaRetencion/CodigoRetencion"/>;
    <xsl:value-of select="LineaRetencion/DescripcionRetencion"/>;
    <xsl:value-of select="LineaRetencion/MonedaRetencion"/>;
    <xsl:value-of select="LineaRetencion/BaseRetencion"/>;
    <xsl:value-of select="LineaRetencion/PorcentajeRetencion"/>;
    <xsl:value-of select="LineaRetencion/ValorRetencion"/>;
  </xsl:template>
  <xsl:template match="NotaCreditoEmitida/InformacionResumen">
    <xsl:value-of select="MonedaResumen"/>;
    <xsl:value-of select="TotalBaseNotaCredito"/>;
    <xsl:value-of select="TotalImpuestos"/>;
    <xsl:value-of select="TotalRetenciones"/>;
    <xsl:value-of select="TotalGeneralNotaCredito"/>;
  </xsl:template>

  <xsl:template match="NotaCreditoEmitida/NumerationExtension">
    <xsl:value-of select="ApprobationNumber"/>;
    <xsl:value-of select="ApprobationPeriod/ApprobationStartingDate"/>;
    <xsl:value-of select="ApprobationPeriod/ApprobationEndingDate"/>;
    <xsl:value-of select="Prefix"/>;
    <xsl:value-of select="StartingAt"/>;
    <xsl:value-of select="EndingAt"/>
  </xsl:template>
</xsl:stylesheet>