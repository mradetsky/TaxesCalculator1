import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    public taxResults: TaxesResult;
    public loading: boolean;
    public salary: number;
    private _baseUrl: string;
    private _http: HttpClient;
    
    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
        this._http = http;
        
    }

    public calculate() {
        this.loading = true;
        var request: TaxesRequest = { salary: this.salary };
        this._http.post<TaxesResult>(this._baseUrl + 'taxes', request).subscribe(result => {
            this.taxResults = result;
            this.loading = false;
        }, error => {
            console.error(error);
            this.loading = false;
        });
    }
}

interface TaxesRequest {
    salary: number;
}

interface TaxesResult {

    grossAnnualSalary: number;
    grossMonthlySalary: number;
    netAnnualSalary: number;
    netMonthlyAnnualSalary: number;
    annualTaxPaid: number;
    monthlyTaxPaid: number;
}
