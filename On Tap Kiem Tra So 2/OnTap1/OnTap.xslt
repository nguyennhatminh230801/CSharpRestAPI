<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" 
	exclude-result-prefixes="msxsl">
    <xsl:output method="html" indent="yes"/>

    <xsl:template match="DanhSachSinhVien">
		<html>
			<body>
				<h2>Danh sách sinh viên</h2>
				<!--<table border="1">
					<tr>
						<td>Mã sinh viên</td>
						<td>Họ tên</td>
						<td>Trình độ</td>
						<td>Giới tính</td>
						<td>Ngày sinh</td>
					</tr>
					<xsl:for-each select="DanhSachSinhVien/SinhVien">
						<tr>
							<td>
								<xsl:value-of select="@maSinhVien"/>
							</td>
							<td>
								<xsl:value-of select="HoTen"/>
							</td>
							<td>
								<xsl:value-of select="TrinhDo"/>
							</td>
							<td>
								<xsl:value-of select="GioiTinh"/>
							</td>
							<td>
								<xsl:value-of select="NgaySinh"/>
							</td>
						</tr>
					</xsl:for-each>
				</table>-->
			</body>
		</html>
    </xsl:template>
</xsl:stylesheet>
