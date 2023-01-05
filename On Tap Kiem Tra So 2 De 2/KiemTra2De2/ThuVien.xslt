<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet 
	version="1.0" 
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
	exclude-result-prefixes="msxsl"
	xmlns:a="http://tempuri.org/ThuVien.xsd">
	
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="/">
		<html>
			<body>
				<h1 style="text-align: center;">Danh mục sách</h1>
				<xsl:for-each select="/a:TV/a:NhaXB">
					<!--xsl: value of lấy giá trị, muốn lấy thuộc tính thì theo cú pháp select="@ + tên thuộc tính"-->
					<p>Nhà xuất bản: <xsl:value-of select="@TenNXB"/></p>
					<table border="1">
						<tr>
							<th>Số thứ tự</th>
							<th>Tên sách</th>
							<th>Số trang</th>
							<th>Giá</th>
						</tr>
						<xsl:for-each select="/a:TV/a:NhaXB/a:Sach">
							<tr>
								<td>
									<xsl:value-of select="position()"/> 
								</td>
								<td>
									<xsl:value-of select="a:TenSach"/>
								</td>
								<td>
									<xsl:value-of select="a:SoTrang"/>
								</td>
								<td>
									<xsl:choose>
										<xsl:when test="a:SoTrang>150">
											<xsl:number value="(a:SoTrang - 150) * 2000 + 100 * 4000 + 50 * 3000"/>
										</xsl:when>
										<xsl:when test="a:SoTrang>100">
											<xsl:number value="(a:SoTrang - 100) * 3000 + 100 * 4000"/>
										</xsl:when>
										<xsl:otherwise>
											<xsl:number value="a:SoTrang * 4000"/>
										</xsl:otherwise>
									</xsl:choose>
								</td>
							</tr>
						</xsl:for-each>
					</table>
				</xsl:for-each>
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
