﻿using dotNetApi.Entities;

namespace dotNetApi.IRepository;

public interface INoteRepository
{
    Task<IEnumerable<Note>> GetNotesAsync();
    Task<Note> GetNoteByIdAsync(int id);
    void CreateNoteAsync(Note note);
    Task<Note> UpdateNoteAsync(Note note);
    Task<bool> DeleteNoteAsync(int id);
}