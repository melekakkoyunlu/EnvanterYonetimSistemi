USE [EnvanterYonetim]
GO

/****** Object:  StoredProcedure [dbo].[sp_GetCustomerSpending]    Script Date: 4.07.2024 18:54:53 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[sp_GetCustomerSpending]
AS
BEGIN
    SELECT
        m.MusteriAd,
        SUM(s.ToplamTutar) AS ToplamHarcama
    FROM
        Musteri m
    JOIN
        Siparis s ON m.MusteriID = s.MusteriID
    GROUP BY
        m.MusteriAd
    ORDER BY
        ToplamHarcama DESC;
END;
GO


