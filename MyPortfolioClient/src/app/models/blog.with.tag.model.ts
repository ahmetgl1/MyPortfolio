import { Tags } from "./tag.model";

export class BlogWithTagsDto  {
    id: number = 0
    title: string ="";
    summary: string ="";
    duration: number = 0;
    publisher: string ="";
    createDate: string = "";
    postURL: string ="";
    imageURL: string ="";
    tags: Tags[] = [];
}