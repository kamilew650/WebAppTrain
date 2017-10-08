import { Component, OnInit } from '@angular/core';

import { Post } from '../../services/post/post';
import { PostService } from '../../services/post/post.service';

@Component({
  selector: 'app-post-view',
  templateUrl: './post-view.component.html',
  styleUrls: ['./post-view.component.css']
})
export class PostViewComponent implements OnInit {
  
  private posts: Post[];

  constructor( private postService: PostService) { }

  ngOnInit() {
    this.getPostes();
  }

  getPostes()
  {
    this.postService.getPost()
      .subscribe( posts => {
        this.posts = posts;
      })
  }

}
