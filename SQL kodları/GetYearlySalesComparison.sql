USE [EnvanterYonetim]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetYearlySalesComparison]    Script Date: 4.07.2024 18:56:12 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetYearlySalesComparison]
AS
BEGIN
    SELECT
        YEAR(SiparisTarih) AS Yil,
        SUM(ToplamTutar) AS ToplamSatis
    FROM
        Siparis
    GROUP BY
        YEAR(SiparisTarih)
    ORDER BY
        Yil;
END;
GO


