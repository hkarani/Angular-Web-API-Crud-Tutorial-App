import { Injectable } from '@angular/core';
import { SuperHero } from '../models/super-hero';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs/internal/Observable';
import { environment } from 'src/environments/environment.development';

@Injectable({
  providedIn: 'root'
})

export class SuperHeroService {
  private url = "SuperHero";
  constructor(private http: HttpClient) { }
  getSuperHeroes() : Observable<SuperHero[]> {
    return this.http.get<SuperHero[]>(`${environment.apiUrl}/${this.url}`);
  }

  updateSuperHero(hero: SuperHero) : Observable<SuperHero[]> {
    return this.http.put<SuperHero[]>(`${environment.apiUrl}/${this.url}`, hero);
  }

  createSuperHero(hero: SuperHero) : Observable<SuperHero[]> {
    return this.http.post<SuperHero[]>(`${environment.apiUrl}/${this.url}`, hero);
  }

  deleteSuperHero(hero: SuperHero) : Observable<SuperHero[]> {
    return this.http.delete<SuperHero[]>(`${environment.apiUrl}/${this.url}/${hero.id}`);
  }

}

