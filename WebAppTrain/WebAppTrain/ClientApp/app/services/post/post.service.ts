import { Injectable } from '@angular/core';
import { Headers, Http } from '@angular/http';

import { Subject } from 'rxjs/Subject';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/observable/throw';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';

import { Post } from './post';

@Injectable()
export class PostService {
    
    constructor( private http: Http) {}

    private url = 'http://localhost:54300/api/post';

    getPost(): Observable<Post[]>{
        return this.http.get(this.url)
            .map(response => response.json() as Post[])
            .catch(this.handleError);
    }

    getOnePost(id: number): Observable<Post>{
        const Url = '${this.url}/${id}';
        return this.http.get(Url)
          .map(response => response.json() as Post)
          .catch(this.handleError);
    }

    private handleError(error: any): Observable<any> {
        console.error('An error occurred', error);
        let errorMessage: string;
        if (error.status === 0) {
          errorMessage = `Server not found`;
        } else {
          if (error.message) {
            errorMessage = `Error: ${+error.status}  ${error.statusText} ${error.message}`;
          } else {
            errorMessage = `Error: ${+error.status}  ${error.statusText}`;
          }
        }
        return Observable.throw(errorMessage || 'Server error');
  }
}
