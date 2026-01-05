# Aging Index Web Application (主要國家老化指數 Web 版)

這是一個將 Windows Forms 應用程式轉換為 ASP.NET Core MVC 的 Web 應用程式。本專案讀取 CSV 檔案中的老化指數資料，並使用網頁圖表 (Chart.js) 與表格進行視覺化呈現。

## 功能特色

*   **資料視覺化**: 使用 Chart.js 繪製互動式折線圖，展示各國老化指數趨勢。
*   **資料列表**: 清晰的表格展示所有詳細數據。
*   **CSV 讀取**: 自動讀取並解析 `Data/主要國家老化指數.csv`。

## 系統需求

*   .NET 9.0 SDK 或更高版本

## 如何執行

1.  開啟終端機 (Terminal) 並進入專案目錄：
   

2.  執行應用程式：
    ```bash
    dotnet run
    ```

3.  開啟瀏覽器並前往終端機顯示的 URL (例如 `http://localhost:5xxx`)。

## 專案結構

*   `Controllers/HomeController.cs`: 處理首頁請求與資料載入。
*   `Models/AgingIndexData.cs`: 資料模型定義。
*   `Services/CsvService.cs`: 負責讀取與解析 CSV 檔案的服務。
*   `Views/Home/Index.cshtml`: 前端頁面，包含 Chart.js 圖表與表格。
*   `Data/主要國家老化指數.csv`: 來源資料檔。

