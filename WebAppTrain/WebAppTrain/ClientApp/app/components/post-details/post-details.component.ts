import { Component, OnInit } from '@angular/core';

import { Post } from '../../services/post/post';

@Component({
  selector: 'app-post-details',
  templateUrl: './post-details.component.html',
  styleUrls: ['./post-details.component.css']
})
export class PostDetailsComponent implements OnInit {

  private post: Post;

  constructor() { }

  ngOnInit() {
  }

}
