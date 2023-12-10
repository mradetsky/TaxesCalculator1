import { HttpClient } from '@angular/common/http';
import { Component, Inject } from '@angular/core';

@Component({
    selector: 'app-home',
    templateUrl: './home.component.html',
})
export class HomeComponent {
    public taxResults: TaxesResult[];
    public loading: boolean;
    public salary: number;

    constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
        this.loading = true;
        http.get<TaxesResult[]>(baseUrl + 'taxes').subscribe(result => {
            this.taxResults = result;
            this.loading = false;
        }, error => {
            console.error(error);
            this.loading = false;
        });
    }

    public calculate() {
        alert(this.salary);
    }
}


interface TaxesResult {
    resultType: string;
    result: number;

}
