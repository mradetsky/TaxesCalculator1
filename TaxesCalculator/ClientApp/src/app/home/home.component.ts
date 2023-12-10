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
    public error: string;
    private _baseUrl: string;
    private _http: HttpClient;
    
    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this._baseUrl = baseUrl;
        this._http = http;
        
    }

    public calculate() {
        this.loading = true;
        this.error = null;
        var request: TaxesRequest = { salary: this.salary };
        this._http.post<TaxesResult>(this._baseUrl + 'taxes', request).subscribe(result => {
            this.taxResults = result;
            this.loading = false;
        }, error => {
            console.error(error);
            this.error = this.getError(error);
            this.loading = false;
        });
    }

    public getError(error: any) {
        
        if (error.error.errors) {
            var errorText = "";
            for (var key in error.error.errors) {
                errorText += key + ":" + error.error.errors[key].join(", ");
            }
            return errorText;
        }
        else return error.error;

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
