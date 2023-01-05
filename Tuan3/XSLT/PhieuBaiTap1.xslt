<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
    <xsl:output method="xml" indent="yes"/>

    <xsl:template match="@* | node()">
		<html>
			<body>
				<table border="2" cellpadding="3">
					<xsl:for-each select="DanhSach/HoaDon/LoaiHang">
						<tr>
							<td>
								<xsl:value-of select="TenHang"/>
							</td>
							<td>
								<xsl:value-of select="SoLuong"/>
							</td>
							<td>
								<xsl:value-of select="DonViTinh"/>
							</td>
							<td>
								<xsl:value-of select="DonGia"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
	    </html>
    </xsl:template>
</xsl:stylesheet>
